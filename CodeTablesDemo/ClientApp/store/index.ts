import * as WeatherForecasts from '../actions/WeatherForecasts';
import * as Counter from '../actions/Counter';
import * as ExternalPaymentTypes from '../actions/ExternalPaymentType';
import * as ExternalPaymentTypeList from '../actions/ExternalPaymentType/ListReducer';
import * as ExternalPaymentTypeForm from '../actions/ExternalPaymentType/FormReducer';

// The top-level state object
export interface ApplicationState {
    counter: Counter.CounterState;
    weatherForecasts: WeatherForecasts.WeatherForecastsState;
    externalPaymentTypes: ExternalPaymentTypes.ExternalPaymentTypeListState;  
    activePaymentType: ExternalPaymentTypes.ExternalPaymentTypeFormState;
}

// Whenever an action is dispatched, Redux will update each top-level application state property using
// the reducer with the matching name. It's important that the names match exactly, and that the reducer
// acts on the corresponding ApplicationState property type.
export const reducers = {
    counter: Counter.reducer,
    weatherForecasts: WeatherForecasts.reducer,
    externalPaymentTypes: ExternalPaymentTypeList.reducer,
    activePaymentType: ExternalPaymentTypeForm.reducer
};

// This type can be used as a hint on action creators so that its 'dispatch' and 'getState' params are
// correctly typed to match your store.
export interface AppThunkAction<TAction> {
    (dispatch: (action: TAction) => void, getState: () => ApplicationState): void;
}
