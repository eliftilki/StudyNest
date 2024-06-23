# StudyNest 

StudyNest System is an educational platform designed to provide users with quick and easy access to educational materials. This platform is designed using a decoupled architecture, utilizing .NET for the backend and React.js for the frontend. MSSQL is used for database management.

## Features

- Quick access to educational materials for users
- Dynamic and interactive user interface
- Backend design following SOLID principles
- Database management with Entity Framework
- Secure data storage and management with MSSQL

## Architecture

- **Backend:** .NET Framework and Entity Framework
- **Frontend:** React.js
- **Database:** MSSQL
- **API:** Backend and frontend components communicate via API

## Requirements

- .NET SDK
- Node.js
- MSSQL Server

## Technologies and Packages Used

- .NET Framework
- Entity Framework
- React.js
- MSSQL

## User Interface Overview
This section provides an overview of the StudyNest project's interface and briefly defines its components. The interface includes a user-web page interaction.

### Design Elements
This subsection details the user interface of StudyNest and explains the usage of these interfaces.

- **Homepage Screen:** When users access the homepage, they can navigate to desired pages from the navbar. The navbar includes sections for categories, contact, registration, and login. If users are not logged in, they can only access the courses and content of the categories. To purchase or view a course, the user must log in. From the homepage, they can also access the top 8 categories.

  ![StudyNest Homepage](https://github.com/eliftilki/StudyNest/assets/134945633/75479e54-2718-49e4-a5a4-fc8857051ebf)

- **Registration Screen:** The user must fill in the necessary information to register. This information is validated on the front end. After clicking the register button, the user's information is sent to the backend using the axios library and saved in the necessary tables.

  ![Registration Screen](https://github.com/eliftilki/StudyNest/assets/134945633/d6a8e9da-ee56-4979-a8cd-6037bfb434b3)

- **Login Screen:** The email and password are checked for compatibility for the user to log in with their registered account. If such a user is found, they are redirected to the homepage. If there is an error with the email or password, the user is notified using the sweetalert library.

  ![Login Screen](https://github.com/eliftilki/StudyNest/assets/134945633/a2827dbb-2b7a-4fa4-958d-9e23d5ed59be)

- **Category Page:** This page displays the categories available on the platform to the user. The component for each category makes requests to the backend using the axios library, and the returned information is stored in the state. This information is then displayed to the user in a structured manner. When the user clicks on any category, they are redirected to the category detail page.

  ![Category Page](https://github.com/eliftilki/StudyNest/assets/134945633/3708bb99-8f27-4c33-8543-db8011d69c60)

- **Category Detail Page:** The category detail page shows the information of the category that the user clicked on in the previous step. Only the courses of that specific category are listed on this page. When the user clicks on any course from this page, they are redirected to the course detail page.

  ![Category Detail Page](https://github.com/eliftilki/StudyNest/assets/134945633/fcbad1cb-dae1-4abc-a9ae-be733c8d10d8)

- **Course Detail Page:** This page provides users with the basic information about a course, such as the course name, description, price, sections, etc. If the user already owns the course, the "Go to Course" button is active; otherwise, the "Add to Cart" button is active. When the "Go to Course" button is clicked, the user is directed to the lesson page, and when the "Add to Cart" button is clicked, the course is added to the cart, and the user is informed that the course has been added to the cart.

  ![Course Detail Page](https://github.com/eliftilki/StudyNest/assets/134945633/667287c4-a41b-47f4-b7c8-ef82e26cf748)

- **Cart Page:** This page shows the courses that the user has added to the cart. It includes the name and price of the added course. When the user clicks the add to cart button, the course is stored in the local storage. When the user navigates to the cart page, the information is retrieved from local storage and displayed.

  ![Cart Page](https://github.com/eliftilki/StudyNest/assets/134945633/f098b96a-70a5-4011-a2dd-192b2135953f)

- **Lesson Page:** After completing the purchase, the user can access the content of the purchased courses by clicking the watch lesson button from the profile or the course page. This page contains the course content.

  ![Lesson Page](https://github.com/eliftilki/StudyNest/assets/134945633/23858690-36ac-4886-8fef-7fc3a53b83a5)

- **Profile Page:** This page shows the user's personal information and the courses they have purchased. Here, they can also perform some actions like changing their password.

  ![Profile Page](https://github.com/eliftilki/StudyNest/assets/134945633/00395fc2-4dbc-4781-ac5b-b067c3c86b2e)




