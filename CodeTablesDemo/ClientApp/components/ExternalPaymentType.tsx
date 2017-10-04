import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { ApplicationState } from '../store';
import * as ExternalPaymentTypesState from '../store/ExternalPaymentTypes';

// At runtime, Redux will merge together...
type ExternalPaymentTypeProps =
    ExternalPaymentTypesState.ExternalPaymentTypesState        // ... state we've requested from the Redux store
    & typeof ExternalPaymentTypesState.actionCreators      // ... plus action creators we've requested
    & RouteComponentProps<{ index: number }>; // ... plus incoming routing parameters

class ExternalPaymentType extends React.Component<ExternalPaymentTypeProps, {}> {
    componentWillMount() {
        // This method runs when the component is first added to the page
        let index = (this.props.match.params.index) || 0;
        this.props.requestExternalPaymentTypes(index);
    }

    componentWillReceiveProps(nextProps: ExternalPaymentTypeProps) {
        // This method runs when incoming props (e.g., route params) change
        let index = (this.props.match.params.index) || 0;
        this.props.requestExternalPaymentTypes(index);
    }

    public render() {
        return <div>
            <h1>ExternalPaymentTypes</h1>
            <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
            {this.renderExternalPaymentTypesTable()}
            {this.renderPagination()}
        </div>;
    }

    private renderExternalPaymentTypesTable() {
        return <table className='table'>
            <thead>
                <tr>
                    <th>Payment Type Seq</th>
                    <th>Payment Type Description</th>
                </tr>
            </thead>
            <tbody>
                {this.props.externalPaymentTypes.map(externalPaymentType =>
                    <tr key={externalPaymentType.paymentTypeSeq}>
                        <td>{externalPaymentType.paymentTypeSeq}</td>
                        <td>{externalPaymentType.paymentTypeDescription}</td>                        
                    </tr>
                )}
            </tbody>
        </table>;
    }

    private renderPagination() {
        let prevIndex = (this.props.index || 0) - 5;
        let nextIndex = (this.props.index || 0) + 5;

        return <p className='clearfix text-center'>
            <Link className='btn btn-default pull-left' to={`/externalpaymenttype/${prevIndex}`}>Previous</Link>
            <Link className='btn btn-default pull-right' to={`/externalpaymenttype/${nextIndex}`}>Next</Link>
            {this.props.isLoading ? <span>Loading...</span> : []}
        </p>;
    }
}

export default connect(
    (state: ApplicationState) => state.externalPaymentTypes, // Selects which state properties are merged into the component's props
    ExternalPaymentTypesState.actionCreators                 // Selects which action creators are merged into the component's props
)(ExternalPaymentType) as typeof ExternalPaymentType;
