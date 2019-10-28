import React, { Component } from 'react';


export class RSVPBox extends Component {
    static displayName = RSVPBox.name;

    constructor(props) {
        super(props);
        this.state = { value: ''};
        this.handleClick = this.handleClick.bind(this);
        this.handleCodeChange = this.handleCodeChange.bind(this);
    }

    handleClick() {
        console.log('A value was sumbitted: ' + this.state.value)
    }

    handleCodeChange(event) {
        this.setState({
            value: event.target.value
        });
    }

    render() {
        return (
            <div>
                Enter your RSVP Code here:
                <input type="text" value={this.state.value} onChange={this.handleCodeChange} name="rsvp_code"/>
                <button type="button" onClick={this.handleClick}>Submit</button>
            </div>
        );
    }
}