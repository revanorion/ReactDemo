import { fetch, addTask } from 'domain-task';
import { Action, Reducer, ActionCreator } from 'redux';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface ExternalPaymentTypeListState {
    isLoading: boolean;
    index?: number;
    externalPaymentTypes: ExternalPaymentType[];
}
export interface ExternalPaymentTypeFormState {
    isLoading: boolean;
    paymentTypeSeq?: number;
    externalPaymentType: ExternalPaymentType;
}

export interface ExternalPaymentType {
    paymentTypeSeq: number;
    paymentTypeDescription: string;
}

export interface ResponseExternalPaymentTypes {
    success: boolean;
    model: ExternalPaymentType[];
}

export interface ResponseExternalPaymentType {
    success: boolean;
    model: ExternalPaymentType;
}
// -----------------
// ACTIONS - These are serializable (hence replayable) descriptions of state transitions.
// They do not themselves have any side-effects; they just describe something that is going to happen.

interface RequestExternalPaymentTypesAction {
    type: 'REQUEST_TRACKING_NUMBERS';
    index: number;
}

interface ReceiveExternalPaymentTypesAction {
    type: 'RECEIVE_TRACKING_NUMBERS';
    index: number;
    externalPaymentTypes: ResponseExternalPaymentTypes;
}

interface RequestExternalPaymentTypeAction {
    type: 'REQUEST_TRACKING_NUMBER';
    paymentTypeSeq: number;
}

interface ReceiveExternalPaymentTypeAction {
    type: 'RECEIVE_TRACKING_NUMBER';
    paymentTypeSeq: number;
    externalPaymentType: ResponseExternalPaymentType;
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
export type KnownListAction = RequestExternalPaymentTypesAction | ReceiveExternalPaymentTypesAction;
export type KnownFormAction = RequestExternalPaymentTypeAction | ReceiveExternalPaymentTypeAction;

export const unloadedListState: ExternalPaymentTypeListState = { externalPaymentTypes: [], isLoading: false };
export const unloadedFormState: ExternalPaymentTypeFormState = { paymentTypeSeq: 0, externalPaymentType: { paymentTypeSeq: 0, paymentTypeDescription:'' }, isLoading: false };
