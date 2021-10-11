import React, { Component } from 'react';

export class Test extends Component {
  static displayName = Test.name;

  render () {
    return (
      <div>
        <h1>Test</h1>
        <p>Frage:</p>
            <p>Test?</p>
            <label for="option_1">Antwort 1 </label>
            <input type="radio" name="Antwort 1" id="option_1"/><br />
            <label for="option_2">Antwort 2 </label>
            <input type="radio" name="Antwort 2" id="option_2"/><br />
            <label for="option_3">Antwort 3 </label>
            <input type="radio" name="Antwort 3" id="option_3"/><br />
            <label for="option_4">Antwort 4 </label>
            <input type="radio" name="Antwort 4" id="option_4"/><br />
            <button onClick>Weiter</button>
      </div>
    );
  }
}
