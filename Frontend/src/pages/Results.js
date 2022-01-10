import React from 'react'

const Results = (props) => {
    return (
        <div className="center Results">
            <table className="table">
                    <thead className="thead-dark">
                        <tr>
                            <th scope="col">Link</th>
                            <th scope="col">Decision</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>{props.formResultUrl}</td>
                            <td id="result">{props.formResultDecision}</td>
                        </tr>
                    </tbody>
                </table>
        </div>
    )
}

export default Results
