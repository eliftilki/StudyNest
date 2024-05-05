import logo from './logo.svg';
import './App.css';
import Index from './components/index.jsx';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Courses from './components/courses.jsx';
import Login from './components/Login.jsx';
import Register from './components/Register.jsx';
import Contact from './components/Contact.jsx';
import Navbar from './components/Navbar.jsx';
import Categories from './components/Categories.jsx';
import CategoriesDetail from './components/CategorieDetail.jsx';

function App() {
  return (
    // <div className="App">
    //   <header className="App-header">
    //     <img src={logo} className="App-logo" alt="logo" />
    //     <p>
    //       Edit <code>src/App.js</code> and save to reload.
    //     </p>
    //     <a
    //       className="App-link"
    //       href="https://reactjs.org"
    //       target="_blank"
    //       rel="noopener noreferrer"
    //     >
    //       Learn React
    //     </a>
    //   </header>
    // </div>
    <>
      <Router>
        <Routes>
          <Route exact path="/" element={<Index/>} />
          {/* <Route exact path="/navbar" element={<Navbar/>} /> */}
          <Route exact path="/courses" element={<Courses/>} />
          {/* <Route exact path="/courses/:courseId" element={<Courses/>} /> */}
          <Route exact path="/login" element={<Login/>} />
          <Route exact path="/register" element={<Register/>} />
          <Route exact path="/contact" element={<Contact/>} />
          <Route exact path="/categories" element={<Categories/>} />
          <Route exact path="/categoriesDetail" element={<CategoriesDetail/>} />
        </Routes>
      </Router>
    </>
  );
}

export default App;
