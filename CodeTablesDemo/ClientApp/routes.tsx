import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import Home from './components/Home';
import FetchData from './containers/FetchData';
import Counter from './containers/Counter';
import ExternalPaymentTypeList from './containers/ExternalPaymentType';
import ExternalPaymentTypeForm from './containers/ExternalPaymentType/ExternalPaymentTypeForm';

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/counter' component={ Counter } />
    <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
    <Route path='/externalpaymenttype/:index?' component={ExternalPaymentTypeList} />
    <Route path='/ExternalPaymentTypeForm/:paymentTypeSeq' component={ExternalPaymentTypeForm} />
</Layout>;
