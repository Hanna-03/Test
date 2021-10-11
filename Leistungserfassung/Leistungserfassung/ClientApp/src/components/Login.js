import React, { Component } from 'react';

componentDidMount(); {
    // Simple POST request with a JSON body using fetch
    const requestOptions = {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ title: 'React POST Request Example' })
    };
    fetch('https://localhost:27017/api/posts', requestOptions)
        .then(response => response.json())
        .then(data => this.setState({ postId: data.id }));
}

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

