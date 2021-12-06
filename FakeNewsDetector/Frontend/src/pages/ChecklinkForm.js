import React, { useEffect, useState } from "react";

const ChecklinkForm = ({onSubmitForm}) => {

    return (
        <div className="container">
            <form className="center divForm" onSubmit={(e) => onSubmitForm(e)}>
                <div className="form-floating center mb-3">
                    <input type="url" className="form-control" id="url" placeholder="Type a link"/>
                    <label htmlFor="InputLink">Link</label>
                </div>
                <button type="submit" className="btn btn-primary">Check</button>
            </form>
        </div>
    )
}

export default ChecklinkForm
