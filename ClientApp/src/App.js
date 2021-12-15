import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Trips } from './components/Trip/Trips';
import { AddTrip } from './components/Trip/AddTrip';

import './custom.css'

export default class App extends Component {
  static displayName = App.name.toUpperCase();

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/addtrip' component={AddTrip} />
        <Route path='/trips' component={Trips} />
      </Layout>
    );
  }
}
