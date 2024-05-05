import React from 'react';
// import '../styles/assets/css/style.css';
// import '../styles/assets/css/bootstrap.min.css';
// import '../styles/assets/css/owl.carousel.min.css';
// import '../styles/assets/css/slicknav.css';
// import '../styles/assets/css/flaticon.css';
// import '../styles/assets/css/progressbar_barfiller.css';
// import '../styles/assets/css/gijgo.css';
// import '../styles/assets/css/animate.min.css'; 
// import '../styles/assets/css/animated-headline.css';
// import '../styles/assets/css/magnific-popup.css';
// import '../styles/assets/css/fontawesome-all.min.css';
// import '../styles/assets/css/themify-icons.css';
// import '../styles/assets/css/slick.css';
// import '../styles/assets/css/nice-select.css';
import Navbar from './Navbar.jsx';
import Footer from './Footer.jsx';
import feature1 from '../styles/assets/img/gallery/featured1.png';
import feature2 from '../styles/assets/img/gallery/featured2.png';
import feature3 from '../styles/assets/img/gallery/featured3.png';
import feature4 from '../styles/assets/img/gallery/featured4.png';
import feature5 from '../styles/assets/img/gallery/featured5.png';
import feature6 from '../styles/assets/img/gallery/featured6.png';
import '../styles/assets/css/course.css'
import topic1 from '../styles/assets/img/gallery/topic1.png';
import topic2 from '../styles/assets/img/gallery/topic2.png';
import topic3 from '../styles/assets/img/gallery/topic3.png';
import topic4 from '../styles/assets/img/gallery/topic4.png';
import topic5 from '../styles/assets/img/gallery/topic5.png';
import topic6 from '../styles/assets/img/gallery/topic6.png';
import topic7 from '../styles/assets/img/gallery/topic7.png';
import topic8 from '../styles/assets/img/gallery/topic8.png';
import icon1 from '../styles/assets/img/icon/icon3.svg';
import icon2 from '../styles/assets/img/icon/icon2.svg';
import icon3 from '../styles/assets/img/icon/icon1.svg';
import { Link } from 'react-router-dom';
/// bu sayfa sadece o kategoriye ait dersleri gösterir 
function CategorieDetail() {
  return (
    <div>
        <Navbar></Navbar>
    <main>
        {/* <!--? slider Area Start--> */}
        {/* <section className="slider-area slider-area2">
            <div className="slider-active">
               
                <div className="single-slider slider-height2">
                    <div className="container">
                        <div className="row">
                            <div className="col-xl-8 col-lg-11 col-md-12">
                                <div className="hero__caption hero__caption2">
                                    <h1 data-animation="bounceIn" data-delay="0.2s">Our courses</h1>
                                   
                                    <nav aria-label="breadcrumb">
                                        <ol className="breadcrumb">
                                            <li className="breadcrumb-item"><a href="index.html">Home</a></li>
                                            <li className="breadcrumb-item"><a href="#">Services</a></li> 
                                        </ol>
                                    </nav>
                                    
                                </div>
                            </div>
                        </div>
                    </div>          
                </div>
            </div>
        </section> */}
        {/* <!-- Courses area start --> */}
        <div className="courses-area section-padding40 fix">
            <div className="container">
                <div className="row justify-content-center">
                    <div className="col-xl-7 col-lg-8">
                        <div className="section-tittle text-center mb-55">
                            <h2>Our featured courses</h2>
                        </div>
                    </div>
                </div>
                <div className="row">
                    <div className="col-lg-4">
                        <div className="properties properties2 mb-30">
                            <div className="properties__card">
                                <div className="properties__img overlay1">
                                    <a href="#"><img src={feature1} alt=""></img></a>
                                </div>
                                <div className="properties__caption">
                                    <p>User Experience</p>
                                    <h3><a href="#">Fundamental of UX for Application design</a></h3>
                                    <p>The automated process all your website tasks. Discover tools and techniques to engage effectively with vulnerable children and young people.
                                    </p>
                                    <div className="properties__footer d-flex justify-content-between align-items-center">
                                        <div className="restaurant-name">
                                            <div className="rating">
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star-half"></i>
                                            </div>
                                            <p><span>(4.5)</span> based on 120</p>
                                        </div>
                                        <div className="price">
                                            <span>$135</span>
                                        </div>
                                    </div>
                                    <a href="#" className="border-btn border-btn2">Find out more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-4">
                        <div className="properties properties2 mb-30">
                            <div className="properties__card">
                                <div className="properties__img overlay1">
                                    <a href="#"><img src={feature2} alt=""></img></a>
                                </div>
                                <div className="properties__caption">
                                    <p>User Experience</p>
                                    <h3><a href="#">Fundamental of UX for Application design</a></h3>
                                    <p>The automated process all your website tasks. Discover tools and techniques to engage effectively with vulnerable children and young people.
                                        
                                    </p>
                                    <div className="properties__footer d-flex justify-content-between align-items-center">
                                        <div className="restaurant-name">
                                            <div className="rating">
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star-half"></i>
                                            </div>
                                            <p><span>(4.5)</span> based on 120</p>
                                        </div>
                                        <div className="price">
                                            <span>$135</span>
                                        </div>
                                    </div>
                                    <a href="#" className="border-btn border-btn2">Find out more</a>
                                </div>
                                
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-4">
                        <div className="properties properties2 mb-30">
                            <div className="properties__card">
                                <div className="properties__img overlay1">
                                    <a href="#"><img src={feature3} alt=""></img></a>
                                </div>
                                <div className="properties__caption">
                                    <p>User Experience</p>
                                    <h3><a href="#">Fundamental of UX for Application design</a></h3>
                                    <p>The automated process all your website tasks. Discover tools and techniques to engage effectively with vulnerable children and young people.
                                        
                                    </p>
                                    <div className="properties__footer d-flex justify-content-between align-items-center">
                                        <div className="restaurant-name">
                                            <div className="rating">
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star-half"></i>
                                            </div>
                                            <p><span>(4.5)</span> based on 120</p>
                                        </div>
                                        <div className="price">
                                            <span>$135</span>
                                        </div>
                                    </div>
                                    <a href="#" className="border-btn border-btn2">Find out more</a>
                                </div>
                                
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-4">
                        <div className="properties properties2 mb-30">
                            <div className="properties__card">
                                <div className="properties__img overlay1">
                                    <a href="#"><img src={feature4} alt=""></img></a>
                                </div>
                                <div className="properties__caption">
                                    <p>User Experience</p>
                                    <h3><a href="#">Fundamental of UX for Application design</a></h3>
                                    <p>The automated process all your website tasks. Discover tools and techniques to engage effectively with vulnerable children and young people.
                                        
                                    </p>
                                    <div className="properties__footer d-flex justify-content-between align-items-center">
                                        <div className="restaurant-name">
                                            <div className="rating">
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star-half"></i>
                                            </div>
                                            <p><span>(4.5)</span> based on 120</p>
                                        </div>
                                        <div className="price">
                                            <span>$135</span>
                                        </div>
                                    </div>
                                    <a href="#" className="border-btn border-btn2">Find out more</a>
                                </div>
                                
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-4">
                        <div className="properties properties2 mb-30">
                            <div className="properties__card">
                                <div className="properties__img overlay1">
                                    <a href="#"><img src={feature5} alt=""></img></a>
                                </div>
                                <div className="properties__caption">
                                    <p>User Experience</p>
                                    <h3><a href="#">Fundamental of UX for Application design</a></h3>
                                    <p>The automated process all your website tasks. Discover tools and techniques to engage effectively with vulnerable children and young people.
                                        
                                    </p>
                                    <div className="properties__footer d-flex justify-content-between align-items-center">
                                        <div className="restaurant-name">
                                            <div className="rating">
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star-half"></i>
                                            </div>
                                            <p><span>(4.5)</span> based on 120</p>
                                        </div>
                                        <div className="price">
                                            <span>$135</span>
                                        </div>
                                    </div>
                                    <a href="#" className="border-btn border-btn2">Find out more</a>
                                </div>
                                
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-4">
                        <div className="properties properties2 mb-30">
                            <div className="properties__card">
                                <div className="properties__img overlay1">
                                    <a href="#"><img src={feature6} alt=""></img></a>
                                </div>
                                <div className="properties__caption">
                                    <p>User Experience</p>
                                    <h3><a href="#">Fundamental of UX for Application design</a></h3>
                                    <p>The automated process all your website tasks. Discover tools and techniques to engage effectively with vulnerable children and young people.
                                    </p>
                                    <div className="properties__footer d-flex justify-content-between align-items-center">
                                        <div className="restaurant-name">
                                            <div className="rating">
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star"></i>
                                                <i className="fas fa-star-half"></i>
                                            </div>
                                            <p><span>(4.5)</span> based on 120</p>
                                        </div>
                                        <div className="price">
                                            <span>$135</span>
                                        </div>
                                    </div>
                                    <a href="#" className="border-btn border-btn2">Find out more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="row justify-content-center">
                    <div className="col-xl-7 col-lg-8">
                        <div className="section-tittle text-center mt-40">
                            <a href="#" className="border-btn btn-more">Load More</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        {/* <!-- Courses area End -->
        <!--? top subjects Area Start --> */}
        <div className="topic-area">
            <div className="container">
                <div className="row justify-content-center">
                    <div className="col-xl-7 col-lg-8">
                        <div className="section-tittle text-center mb-55">
                            <h2>Explore top subjects</h2>
                        </div>
                    </div>
                </div>
                <div className="row">
                    <div className="col-lg-3 col-md-4 col-sm-6 topic">
                        <div className="single-topic text-center mb-30">
                            <div className="topic-img">
                                <img src={topic1} alt=""></img>
                                <div className="topic-content-box">
                                    <div className="topic-content">
                                        <h3><a href="#">Programing</a></h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-4 col-sm-6 topic">
                        <div className="single-topic text-center mb-30">
                            <div className="topic-img">
                                <img src={topic2} alt=""></img>
                                <div className="topic-content-box">
                                    <div className="topic-content">
                                        <h3><a href="#">Programing</a></h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-4 col-sm-6 topic">
                        <div className="single-topic text-center mb-30">
                            <div className="topic-img">
                                <img src={topic3} alt=""></img>
                                <div className="topic-content-box">
                                    <div className="topic-content">
                                        <h3><a href="#">Programing</a></h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-4 col-sm-6 topic">
                        <div className="single-topic text-center mb-30">
                            <div className="topic-img">
                                <img src={topic4} alt=""></img>
                                <div className="topic-content-box">
                                    <div className="topic-content">
                                        <h3><a href="#">Programing</a></h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-4 col-sm-6 topic">
                        <div className="single-topic text-center mb-30">
                            <div className="topic-img">
                                <img src={topic5} alt=""></img>
                                <div className="topic-content-box">
                                    <div className="topic-content">
                                        <h3><a href="#">Programing</a></h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-4 col-sm-6 topic">
                        <div className="single-topic text-center mb-30">
                            <div className="topic-img">
                                <img src={topic6} alt=""></img>
                                <div className="topic-content-box">
                                    <div className="topic-content">
                                        <h3><a href="#">Programing</a></h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-4 col-sm-6 topic">
                        <div className="single-topic text-center mb-30">
                            <div className="topic-img">
                                <img src={topic7} alt=""></img>
                                <div className="topic-content-box">
                                    <div className="topic-content">
                                        <h3><a href="#">Programing</a></h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-3 col-md-4 col-sm-6 topic">
                        <div className="single-topic text-center mb-30">
                            <div className="topic-img">
                                <img src={topic8} alt=""></img>
                                <div className="topic-content-box">
                                    <div className="topic-content">
                                        <h3><a href="#">Programing</a></h3>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="row justify-content-center">
                    <div className="col-xl-12">
                        <div className="section-tittle text-center mt-20">
                           
                            <Link to={"/categories"}>
                            <a href="courses.html" className="border-btn btn-more">View More Subjects</a>
                            </Link>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        {/* <!-- top subjects End -->  
        <!-- ? services-area --> */}
        <div className="services-area services-area2 section-padding40">
            <div className="container">
                <div className="row justify-content-sm-center">
                    <div className="col-lg-4 col-md-6 col-sm-8">
                        <div className="single-services mb-30">
                            <div className="features-icon">
                                <img src={icon1} alt=""></img>
                            </div>
                            <div className="features-caption">
                                <h3>60+ UX courses</h3>
                                <p>The automated process all your website tasks.</p>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-4 col-md-6 col-sm-8">
                        <div className="single-services mb-30">
                            <div className="features-icon">
                                <img src={icon2} alt=""></img>
                            </div>
                            <div className="features-caption">
                                <h3>Expert instructors</h3>
                                <p>The automated process all your website tasks.</p>
                            </div>
                        </div>
                    </div>
                    <div className="col-lg-4 col-md-6 col-sm-8">
                        <div className="single-services mb-30">
                            <div className="features-icon">
                                <img src={icon3} alt=""></img>
                            </div>
                            <div className="features-caption">
                                <h3>Life time access</h3>
                                <p>The automated process all your website tasks.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>
    
      <Footer></Footer>
      {/* <!-- Scroll Up --> */}
      <div id="back-top" >
        <a title="Go to Top" href="#"> <i className="fas fa-level-up-alt"></i></a>
    </div>
    </div>
  );
}
export default CategorieDetail;