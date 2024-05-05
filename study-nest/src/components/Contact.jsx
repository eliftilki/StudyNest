import React from 'react';
import { Formik, Form, Field, ErrorMessage } from 'formik';

import { useState } from 'react';
import * as Yup from 'yup';
import  { useRef } from 'react';
import emailjs from '@emailjs/browser';
import Swal from 'sweetalert2';
import Navbar from './Navbar';
import Footer from './Footer';
import '../styles/assets/css/contact.css';
const Contact = () => {
  const initialValues = {
    firstName: '',
    lastName: '',
    email: '',
    message: '',
  };
  const [lng, setLng] = useState(localStorage.getItem("selectedLanguage"));
  console.log("lng:"+lng);
  const validationSchema = Yup.object().shape({
    firstName: Yup.string().required('İsim gereklidir.'),
    lastName: Yup.string().required('Soyisim gereklidir.'),
    email: Yup.string().email('Geçerli bir e-posta adresi girin.').required('E-posta gereklidir.'),
    message: Yup.string().required('Mesaj gereklidir.'),
  });

  const handleSubmit = (values) => {
    // Form gönderildiğinde yapılacak işlemi burada gerçekleştirin.
    console.log(values);
     const templateParams = {
      from_name: values.firstName + " " + values.lastName,
      firstName: values.firstName,
      lastName: values.lastName,
      email: values.email,
      message: values.message,
      
    };
    emailjs.send('service_wxzeb5k', 'template_qvqz11n', templateParams, 'UdzN8CHhQc3Ba97PS')
      .then((result) => {
        console.log(result.text);
        Swal.fire({
          icon: 'success',
          title: 'Mesajınız başarıyla gönderildi.',
          showConfirmButton: false,
          timer: 1500
        })
      }
      , (error) => {
        console.log(error.text);
      });



   
  
  };

  return (
    <div>
      <Navbar />
      <h2 style={{textAlign:"center",marginTop:"7%"}}>Contact Form</h2>
      <div className='main-section'>
      <div className='container'>
        <div className='row'>
          
          <Formik
        initialValues={initialValues}
        validationSchema={validationSchema}
        onSubmit={handleSubmit}
      >
        <Form  className='contact-form'>
          <div className="form-group">
            <label htmlFor="firstName">{lng === "en" ? "Name" : "İsim"}</label>
            <Field type="text" name="firstName" className="form-control" />
            <ErrorMessage name="firstName" component="div" className="text-danger" />
          </div>
          <div className="form-group">
            <label htmlFor="lastName">{lng === "en" ? "Surname" : "Soyisim"}</label>
            <Field type="text" name="lastName" className="form-control" />
            <ErrorMessage name="lastName" component="div" className="text-danger" />
          </div>
          <div className="form-group">
            <label htmlFor="email">{lng === "en" ? "Email" : "E-posta"}</label>
            <Field type="email" name="email" className="form-control" />
            <ErrorMessage name="email" component="div" className="text-danger" />
          </div>
          <div className="form-group">
            <label htmlFor="message">{lng === "en" ? "Message" : "Mesaj"}</label>
            <Field as="textarea" name="message" className="form-control" />
            <ErrorMessage name="message" component="div" className="text-danger" />
          </div>
          <button type="submit" className="btn btn-primary btn-send">{lng === "en" ? "Send" : "Gönder"}</button>
        </Form>
      </Formik>
          
        </div>

      </div>
      </div>
      
      
      <Footer></Footer>
    </div>
  );
};

export default Contact;

