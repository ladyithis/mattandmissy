import React, { Component } from 'react';
import { RSVPBox } from './RSVPBox';


export class RSVPHome extends Component {
    static displayName = RSVPHome.name;

    constructor(props) {
        super(props);
    }

    render() {
        return(
            <div>
                <h1>Wedding RSVP</h1>
                <RSVPBox/>
            </div>
        );
    }
}