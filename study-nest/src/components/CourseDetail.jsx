import React from 'react';

const CourseDetailPage = ({ course }) => {
  return (
    <div className="course-detail-container">
      <div className="course-detail-header">
        <img src={course.photo} alt={course.name} />
      </div>
      <div className="course-detail-body">
        <h2>{course.name}</h2>
        <p>{course.description}</p>
        <ul>
          {course.sections.map((section, index) => (
            <li key={index}>{section}</li>
          ))}
        </ul>
      </div>
      <div className="course-detail-footer">
        <div className="course-price">{course.price} TL</div>
        <button className="purchase-button">Satın Al</button>
      </div>
    </div>
  );
};

export default CourseDetailPage;
