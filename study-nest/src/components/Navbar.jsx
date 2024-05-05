
// import React from 'react';
// import { Link } from 'react-router-dom';

// import '../styles/assets/css/navbar.css';
// import logo from '../images/img/logo/logo.png';
// function Navbar () {
//   return (
//     <div className='navbar-top'>
//       <div id="preloader-active">
//         <div className="preloader d-flex align-items-center justify-content-center">
//             <div className="preloader-inner position-relative">
//                 <div className="preloader-circle"></div>
//                 <div className="preloader-img pere-text" style={{width:"25%",paddingLeft:"1.5rem"}}>
//                     <img src={logo} alt="" ></img>
//                 </div>
//             </div>
//         </div>
//     </div>
//     {/* <!-- Preloader Start --> */}
//     <div className="header">
//         {/* <!-- Header Start --> */}
//         <div className="header-area header-transparent">
//             <div className="main-header ">
//                 <div className="header-bottom  header-sticky">
                                  
//                     <div className="container-fluid"  style={{display:'flex', flexDirection:'row', justifyContent:'space-between',width:"100%"}}>
//                         <div className="row align-items-center main-row">
//                             {/* <!-- Logo --> */}
//                             <div className="col-xl-2 col-lg-2">
//                                 <div className="logo">
                                    
//                                         <Link to={`/`}>
//                                         <img src="assets/img/logo/logo.png" alt=""></img>
//                                         </Link>
//                                         {/* <a href="index.html"></a> */}
//                                         {/* <img src="assets/img/logo/logo.png" alt=""></img></a> */}
//                                 </div>
//                             </div>
//                             <div className="col-xl-10 col-lg-10"  >
//                                 <div className="menu-wrapper d-flex align-items-center justify-content-end">
//                                     {/* <!-- Main-menu --> */}
//                                     <div className="main-menu d-none d-lg-block">
//                                         <nav>
//                                             <ul id="navigation">                                                                                          
//                                                 <li className="active" >
//                                                     <Link to={`/`}>Home</Link>
                                                
//                                                 </li>
//                                                 <li>
//                                                 <Link to={`/courses`}>Courses</Link>
//                                                 </li>
                                               
                                               
//                                                 <li>
//                                                 <Link to={`/contact`}>Contact</Link>
//                                                 </li>
//                                                 {/* <!-- Button --> */}
//                                                 <li className="button-header margin-left ">
                                                   
//                                                     <Link className='btn' to={`/register`}>Join</Link>
//                                                 </li>
//                                                 <li className="button-header">
//                                                 <Link  className=" btn btn3" to={`/login`}>Login</Link>
//                                                 </li>
//                                             </ul>
//                                         </nav>
//                                     </div>
//                                 </div>
//                             </div> 
//                             {/* <!-- Mobile Menu --> */}
//                             <div className="col-12">
//                                 <div className="mobile_menu d-block d-lg-none"></div>
//                             </div>
//                         </div>
//                     </div>
//                 </div>
//             </div>
//         </div>
//         {/* <!-- Header End --> */}
//     </div>
//     </div>
//   )
// }
// export default Navbar;
import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import logo from '../images/img/logo/logo.png';
 import '../styles/assets/css/navbar.css';


const Navbar = () => {
  const [isLoggedIn, setIsLoggedIn] = useState(false); // Kullanıcı giriş yapmış mı?

  // Kullanıcı giriş yaparsa bu fonksiyon çalışır
  const handleLogin = () => {
    // Kullanıcı giriş yaptığında yapılacak işlemler buraya eklenebilir
    setIsLoggedIn(true);
  };

  // Kullanıcı çıkış yaparsa bu fonksiyon çalışır
  const handleLogout = () => {
    // Kullanıcı çıkış yaptığında yapılacak işlemler buraya eklenebilir
    setIsLoggedIn(false);
  };

  return (
    <div className='navbar-top'>
      <div id="preloader-active">
        <div className="preloader d-flex align-items-center justify-content-center">
          <div className="preloader-inner position-relative">
            <div className="preloader-circle"></div>
            {/* <div className="preloader-img pere-text" style={{ width: "25%", paddingLeft: "1.5rem" }}>
              <img src={logo} alt=""></img>
            </div> */}
          </div>
        </div>
      </div>
      <div className="header">
        <div className="header-area header-transparent">
          <div className="main-header ">
            <div className="header-bottom  header-sticky">
              <div className="container-fluid" style={{ display: 'flex', flexDirection: 'row', justifyContent: 'space-between', width: "100%" }}>
                <div className="row align-items-center main-row">
                  <div className="col-xl-2 col-lg-2">
                    <div className="logo">
                      <Link to={`/`}>
                        <img src={logo} alt=""></img>
                      </Link>
                    </div>
                  </div>
                  <div className="col-xl-10 col-lg-10"  >
                    <div className="menu-wrapper d-flex align-items-center justify-content-end">
                      <div className="main-menu d-none d-lg-block">
                        <nav>
                          <ul id="navigation">
                            <li className="active">
                              <Link to={`/`}>Home</Link>
                            </li>
                            <li>
                              <Link to={`/courses`}>Courses</Link>
                            </li>
                            <li>
                              <Link to={`/contact`}>Contact</Link>
                            </li>
                            {isLoggedIn ? (
                              <li className="dropdown">
                                <span className="dropdown-toggle" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                  <img src="path_to_avatar_image" alt="User Avatar" className="avatar" />
                                </span>
                                <div className="dropdown-menu" aria-labelledby="dropdownMenuButton">
                                  <Link className="dropdown-item" to="/profile">Profile</Link>
                                  <Link className="dropdown-item" to="/cart">Cart</Link>
                                  <button className="dropdown-item" onClick={handleLogout}>Logout</button>
                                </div>
                              </li>
                            ) : (
                              <>
                                <li className="button-header margin-left">
                                  <Link className='btn' to={`/register`}>Join</Link>
                                </li>
                                <li className="button-header">
                                  <Link className="btn btn3" to={`/login`}>Login</Link>
                                </li>
                              </>
                            )}
                          </ul>
                        </nav>
                      </div>
                    </div>
                  </div>
                  <div className="col-12">
                    <div className="mobile_menu d-block d-lg-none"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Navbar;
