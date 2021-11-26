import React, { useEffect, useState } from "react";

const History = () => {
    const [History, setHistory] = useState([])

    useEffect(() => {    
        fetch('https://localhost:5003/ResultsHistory', {
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
                        {/* Delete This */}
                        <tr>
                            <td>https://news.cornell.edu/stories/2021/11/900-mile-mantle-pipeline-connects-galapagos-panama</td>
                            <td>Fake</td>
                            <td>12/6/2021</td>
                        </tr>
                        <tr>
                            <td>https://caseyhandmer.wordpress.com/2021/11/17/science-upside-for-starship/</td>
                            <td>Real</td>
                            <td>11/6/2021</td>
                        </tr>
                        <tr>
                            <td>https://edition.cnn.com/style/article/cary-joji-fukunaga-interview-beasts-of-no-nation-criterion-spc-intl/index.html</td>
                            <td>Real</td>
                            <td>26/9/2021</td>
                        </tr>

                        {/* DON'T Delete This */}
                        {
                            History.map((item, i) => {
                                return <tr>
                                            <td>{item.link.url}</td>
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
