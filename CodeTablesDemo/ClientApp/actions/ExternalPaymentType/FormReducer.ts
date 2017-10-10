import { fetch, addTask } from 'domain-task';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from '../../store';
import { KnownFormAction, ResponseExternalPaymentType, ExternalPaymentTypeFormState, unloadedFormState } from './';


export const actionCreators = {
    requestExternalPaymentType: (paymentTypeSeq: number): AppThunkAction<KnownFormAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        //if (paymentTypeSeq !== getState().activePaymentType.paymentTypeSeq) {
            let fetchTask = fetch(`api/ExternalPaymentType/GetExternalPaymentType?paymentTypeSeq=${paymentTypeSeq}`)
                .then(response => response.json() as Promise<ResponseExternalPaymentType>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_TRACKING_NUMBER', paymentTypeSeq: paymentTypeSeq, externalPaymentType: data });
                });

            addTask(fetchTask); // Ensure server-side prerendering waits for this to complete
            dispatch({ type: 'REQUEST_TRACKING_NUMBER', paymentTypeSeq: paymentTypeSeq });
        //}
    }
}

export const reducer: Reducer<ExternalPaymentTypeFormState> = (state: ExternalPaymentTypeFormState, incomingAction: Action) => {
    const action = incomingAction as KnownFormAction;
    switch (action.type) {
        case 'REQUEST_TRACKING_NUMBER':
            return {
                paymentTypeSeq: action.paymentTypeSeq,
                externalPaymentType: state.externalPaymentType,
                isLoading: true
            };
        case 'RECEIVE_TRACKING_NUMBER':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.paymentTypeSeq === state.paymentTypeSeq && action.externalPaymentType.success) {
                return {
                    paymentTypeSeq: action.paymentTypeSeq,
                    externalPaymentType: action.externalPaymentType.model,
                    isLoading: false
                };
            }
            break;
        default:
            // The following line guarantees that every action in the KnownAction union has been covered by a case above
            const exhaustiveCheck: never = action;
    }

    return state || unloadedFormState;
};