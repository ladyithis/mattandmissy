import React, { Component } from 'react';
import { RSVPBox } from './RSVPBox';


export class RSVPHome extends Component {
    static displayName = RSVPHome.name;

    constructor(props) {
        super(props);
        this.state = { hidden: true };
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() {
        this.setState({
            hidden: !this.state.hidden
        });
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