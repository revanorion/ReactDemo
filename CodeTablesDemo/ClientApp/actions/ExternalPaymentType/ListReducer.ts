import { fetch, addTask } from 'domain-task';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from '../../store';
import { KnownListAction, ResponseExternalPaymentTypes, ExternalPaymentTypeListState, unloadedListState}  from './';

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestExternalPaymentTypes: (index: number): AppThunkAction<KnownListAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        if (index !== getState().externalPaymentTypes.index) {
            let fetchTask = fetch(`api/ExternalPaymentType/GetExternalPaymentTypes?index=${index}`)
                .then(response => response.json() as Promise<ResponseExternalPaymentTypes>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_TRACKING_NUMBERS', index: index, externalPaymentTypes: data });
                });

            addTask(fetchTask); // Ensure server-side prerendering waits for this to complete
            dispatch({ type: 'REQUEST_TRACKING_NUMBERS', index: index });
        }
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.


export const reducer: Reducer<ExternalPaymentTypeListState> = (state: ExternalPaymentTypeListState, incomingAction: Action) => {
    const action = incomingAction as KnownListAction;
    switch (action.type) {
        case 'REQUEST_TRACKING_NUMBERS':
            return {
                index: action.index,
                externalPaymentTypes: state.externalPaymentTypes,
                isLoading: true
            };
        case 'RECEIVE_TRACKING_NUMBERS':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.index === state.index && action.externalPaymentTypes.success) {
                return {
                    index: action.index,
                    externalPaymentTypes: action.externalPaymentTypes.model,
                    isLoading: false
                };
            }
            break;
        default:
            // The following line guarantees that every action in the KnownAction union has been covered by a case above
            const exhaustiveCheck: never = action;
    }

    return state || unloadedListState;
};