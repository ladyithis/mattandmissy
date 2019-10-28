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
                <Link to="/rsvp">RSVP here</Link>
            </div>
        );
    }
}
