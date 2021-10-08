import React, { Component } from 'react';

export class Evaluation extends Component {
    static displayName = Evaluation.name;

    render() {
        return (
            <div>
                <h1>Ergebnis</h1>
                <p>Punkte:</p>
                <p><a href='/Home'><strong>Home</strong></a></p>
            </div>
        );
    }
}
