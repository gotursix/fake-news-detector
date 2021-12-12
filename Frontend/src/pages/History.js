import React, { useEffect, useState } from "react";

const History = () => {
    const [History, setHistory] = useState([])

    useEffect(() => {    
        fetch('https://localhost:44335/ResultsHistory', {
            method: 'GET',
            headers: { 'Content-Type': 'application/json' },
          })
          .then(response => response.json())
          .then(data => {
                console.log(data)
                setHistory(data)
            })
    }, []);

    return (
            <div className="historyTable">
                <table className="table">
                    <thead className="thead-dark">
                        <tr>
                            <th scope="col">Link</th>
                            <th scope="col">Decision</th>
                            <th scope="col">Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            History.map((item, i) => {
                                return <tr>
                                            <td>{item.link}</td>
                                            <td>{item.decision}</td>
                                            <td>{new Date(item.searchDate).toLocaleDateString("en-US")}</td>
                                    </tr>
                            })
                        }
                    </tbody>
                </table>
            </div>
    )
}

export default History
