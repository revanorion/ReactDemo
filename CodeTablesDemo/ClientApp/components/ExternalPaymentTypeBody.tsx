import * as React from 'react';
import ExternalPaymentTypeList from '../containers/ExternalPaymentType';
import { ApplicationState } from '../store';
import { connect } from 'react-redux';
import { actionCreators } from '../actions/ExternalPaymentType/FormReducer';

export class ExternalPaymentTypeBody extends React.Component<{}, {}> {
    public render() {
        const props = this.props.children
        return (
            <div>              
            </div>
        );
    }
}

