import './App.css';
import Navbar from './components/Navbar/index.js';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Home from "./pages/index"
import Checklink from "./pages/Checklink"
import History from "./pages/History"
import About from "./pages/About"

function App() {
  return (
    <Router>
      <Navbar/>
      <Routes>
        <Route path="/" exact element={<Home/>} />
        <Route path="/Checklink" element={<Checklink/>} />
        <Route path="/History" element={<History/>} />
        <Route path="/About" element={<About/>} />
      </Routes>
    </Router>
  );
}

export default App;
