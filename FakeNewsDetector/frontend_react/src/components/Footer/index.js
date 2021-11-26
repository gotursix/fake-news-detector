import React from 'react'
import github from '../../Assets/github.png'
import linkedin from '../../Assets/linkedin.png'

const index = () => {
    return (
        <div className="footer">
            <div className="linkedin">
                <img src={linkedin} alt="Linkedin"/>
                <div>
                    <a href="https://www.linkedin.com/in/cristian-bucataru/">Bucataru Cristian</a>
                    <a href="https://www.linkedin.com/in/bujor-bogdan-5a5314211/">Bujor Bogdan</a>
                    <a href="https://www.linkedin.com/in/andreea-madalina-vina-328169215">Vina Andreea</a>
                    <a href="https://www.linkedin.com/in/valentin-grigorean-72b7a6210/">Grigorean Valentin</a>
                </div>
            </div>
            <div className="github">
                <img src={github} alt="Github"/>
                <div>
                    <a href="https://github.com/cristibctr">Bucataru Cristian</a>
                    <a href="https://github.com/bogdanbujor99">Bujor Bogdan</a>
                    <a href="https://github.com/AndreeaVina">Vina Andreea</a>
                    <a href="https://github.com/gotursix">Grigorean Valentin</a>
                </div>
            </div>
        </div>
    )
}

export default index
