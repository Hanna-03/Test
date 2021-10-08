import React, { Component } from 'react';

export class Test extends Component {
  static displayName = Test.name;

  render () {
    return (
      <div>
        <h1>Test</h1>
        <p>Frage:</p>
          <p>Test?</p>
          <li><button type radioGroup>Antwort 1</button></li>
          <button type radioGroup>Antwort 2</button>
          <button type radioGroup>Antwort 3</button>
          <button type radioGroup>Antwort 4</button>
          <button onClick>Weiter</button>
      </div>
    );
  }
}
