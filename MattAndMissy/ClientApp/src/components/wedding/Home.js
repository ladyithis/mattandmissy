import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class WeddingHome extends Component {
    static displayName = WeddingHome.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <h1>Wedding Home</h1>
                <Link to="/rsvp">RSVP here</Link>
            </div>
        );
    }
}
