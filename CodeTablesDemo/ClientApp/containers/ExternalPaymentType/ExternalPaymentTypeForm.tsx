import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { ApplicationState } from '../../store';
import { ExternalPaymentTypeFormState } from '../../actions/ExternalPaymentType';
import { actionCreators } from '../../actions/ExternalPaymentType/FormReducer';

// At runtime, Redux will merge together...
type ExternalPaymentTypeProps =
    ExternalPaymentTypeFormState        // ... state we've requested from the Redux store
    & typeof actionCreators      // ... plus action creators we've requested
    & RouteComponentProps<{ paymentTypeSeq: number }>; // ... plus incoming routing parameters

class ExternalPaymentTypeForm extends React.Component<ExternalPaymentTypeProps, {}> {
    componentWillMount() {
        // This method runs when the component is first added to the page
        console.log('lol');
        let paymentTypeSeq = (this.props.match.params.paymentTypeSeq) || 0;
        //this.props.requestExternalPaymentType(paymentTypeSeq);
    }

    componentWillReceiveProps(nextProps: ExternalPaymentTypeProps) {
        // This method runs when incoming props (e.g., route params) change
        let paymentTypeSeq = (this.props.match.params.paymentTypeSeq) || 0;
        //this.props.requestExternalPaymentType(paymentTypeSeq);
    }

    public render() {
        return <div>
            <h1>ExternalPaymentTypes Form</h1>
            {this.renderForm()}
        </div>;
    }

    private renderForm() {
        return <table className='table'>
            <label>Payment Type Seq: {this.props.externalPaymentType.paymentTypeSeq}</label>
            <label>Payment Type Description: {this.props.externalPaymentType.paymentTypeSeq}</label>         
        </table>;
    }
}

export default connect(
    (state: ApplicationState) => state.activePaymentType, // Selects which state properties are merged into the component's props
    actionCreators                 // Selects which action creators are merged into the component's props
)(ExternalPaymentTypeForm) as typeof ExternalPaymentTypeForm;
