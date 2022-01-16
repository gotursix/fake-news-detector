import React from 'react'

const Home = () => {
    return (
        <div>
            <div class="home_page">
                <img class="image" src={require('../Assets/fake.jpg')}></img>
                <p>Nowadays, distinguishing between real and fake news has become a challenging task. But it can be achieved using machine learning concepts and algorithms. Fake news detection is one of the most interesting and easy machine learning project ideas well suited for beginners.</p>
                </div>
            <div class="team">
                <p>
                    The project was realised by Vina Andreea as Madalina, Bujor Bogdan as Constantin, Bucataru Cristian as Stefan and Grigorean Valentin as Valentin.
                </p>
            </div>
        </div>
    )
}

export default Home