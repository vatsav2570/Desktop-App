# Form Submission Web Application

This is a simple web application that allows users to create and view form submissions. It consists of a frontend implemented in Visual Basic .NET using Windows Forms, and a backend implemented in Node.js with Express and TypeScript.

## Features

- Create new form submissions with name, email, phone, GitHub repo link, and stopwatch time.
- View submitted forms with pagination (Previous and Next buttons).
- Delete submitted forms.
- Search for submissions by email.
- Backend API endpoints for submitting, reading, deleting, and searching form submissions.

## Installation

### Frontend (Windows Forms App)

1. Open the `FormSubmissionApp.sln` file in Visual Studio.
2. Build the solution to restore dependencies and compile the application.
3. Run the application to start the frontend.

### Backend (Express Server)

1. Navigate to the `backend` directory in your terminal.
2. Run `npm install` to install dependencies.
3. Run `npm start` to start the backend server.

## Usage

1. Open the frontend application to create new submissions or view existing ones.
2. Use the pagination buttons to navigate through submissions.
3. Use the search bar to search for submissions by email.
4. Click the delete button to delete a submission.

## API Endpoints

- `GET /ping`: Check if the server is running.
- `POST /submit`: Submit a new form entry.
- `GET /read?index=<index>`: Read a form entry by index.
- `DELETE /delete?name=<name>`: Delete a form entry by name.
- `GET /search?email=<email>`: Search for a form entry by email.

## Technologies Used

- Frontend: Visual Basic .NET, Windows Forms
- Backend: Node.js, Express, TypeScript
- Database: JSON file storage

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
