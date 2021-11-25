import React, { useEffect, useState } from "react";

const Checklink = () => {
    const [Link, setLink] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();
        const data = new FormData(e.target);
        fetch('https://localhost:5003/CheckLink', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: data,
          });
        console.log(data);
    }

    return (
        <div className="container">
            <form className="center divForm" onSubmit={handleSubmit}>
                <div className="form-floating center mb-3">
                    <input type="Link" className="form-control" id="floatingInput" placeholder="Type a link" onChange={e => setLink(e.target.value)}/>
                    <label htmlFor="InputLink">Link</label>
                </div>
                <button type="submit" className="btn btn-primary">Check</button>
            </form>
        </div>
    )
}

export default Checklink
