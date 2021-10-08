import React, { Component } from 'react';

export class Login extends Component {
    static displayName = Login.name;

    render() {
        return (
            <div>
                <h1>Login</h1>
                <p>Benutzername:</p>
                <input type="text" name="username" placeholder="Benutzername"></input>
                <p>Passwort:</p>
                <input type="password" name="password" placeholder="Passwort"></input>
                <button>Login</button>
            </div>
        );
    }
}

