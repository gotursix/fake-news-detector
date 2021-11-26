import './App.css';
import Navbar from './components/Navbar/index.js';
import Footer from './components/Footer/index';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Home from "./pages/index"
import Checklink from "./pages/Checklink"
import History from "./pages/History"
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <Router>
      <Navbar/>
      <Routes>
        <Route path="/" exact element={<Home/>} />
        <Route path="/Checklink" element={<Checklink/>} />
        <Route path="/History" element={<History/>} />
      </Routes>
      <Footer/>
    </Router>
  );
}

export default App;
