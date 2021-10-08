import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Hallo, Azubi!</h1>
        <p>Ergebnisse:</p>
        <ul>
          <li>Test 1: 9/10 Punkte</li>
          <li>Test 2: 10/10 Punkte</li>
          <li>Test 3: 8/10 Punkte</li>
        </ul>
        <p>Tests:</p>
        <ul>
          <li><a href='/Test'><strong>Test 4</strong></a></li>
          <li><a href='/Test'><strong>Test 5</strong></a></li>
          <li><a href='/Test'><strong>Test 6</strong></a></li>
        </ul>
      </div>
    );
  }
}
