import React, { useEffect, useState } from "react";
import Results from "./Results";
import ChecklinkForm from "./ChecklinkForm";

const Checklink = () => {
    const [ResultsDB, setResultsDB] = useState([])

    const handleSubmit = (e) => {
        e.preventDefault();
        fetch('https://localhost:5003/NewsResult', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: `{
                "url" : "${e.target[0].value}"
            }`,
          })
          .then(response => response.json())
          .then(data => {
              console.log(data)
              setResultsDB(data)
          })
          .catch(error => console.log(error));
    }

    if (ResultsDB.length == 0)
    {
        return (
            <div>
                <ChecklinkForm onSubmitForm={handleSubmit}/>
            </div>
        )
    }
    else
        return (
            <div>
                <Results formResultUrl={ResultsDB['link']} formResultDecision={ResultsDB['decision']}/>
            </div>
        )
}

export default Checklink
