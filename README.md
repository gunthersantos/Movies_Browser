# Movie Browser Application 🎬

## Project Overview  
This project is a **Movie Browser Application** developed for the **Rapid Application Development** course.  
The application allows users to:  
- Search for movies.  
- View detailed information about selected movies.  
- Manage a personalized watchlist.  

The project integrates with the **OMDb API** to fetch real-time movie data and provides a user-friendly interface built with Windows Forms in **C#**.  

---

## Features 🚀  
- **Search Movies**: Search for movies using keywords and retrieve a list of results.  
- **View Movie Details**: Display detailed information about a selected movie, including:  
  - Title  
  - Year  
  - Genre  
  - Plot  
  - Poster (cover image).  
- **Watchlist Management**: Add movies to a personalized watchlist.  
- **Responsive UI**: A clean and functional Windows Forms interface with proper layout management.  

---

## Technologies Used 🛠️  
- **Programming Language**: C#  
- **Framework**: Windows Forms (.NET Framework)  
- **API Integration**: OMDb API ([OMDb API Documentation](https://www.omdbapi.com/))  
- **JSON Parsing**: Newtonsoft.Json  

---

## How to Run the Project ⚡  
1. Clone the repository to your local machine:  
   ```bash
   git clone https://github.com/your-repository-url.git
2. Open the solution file (.sln) in Visual Studio.
Install dependencies:
Newtonsoft.Json
System.Net.Http (already included in .NET Framework).
Replace the placeholder apiKey in the MovieAPIService class with your own OMDb API key.
Build the project:
Select Build > Rebuild Solution in Visual Studio.
Run the application:
Press F5 or select Debug > Start Debugging.

MovieAPI/
├── MovieAPI/
│   ├── Form1.cs             # Main form logic
│   ├── Form1.Designer.cs    # UI layout
│   ├── MovieAPIService.cs   # API integration
│   └── Program.cs           # Application entry point
├── Properties/
│   └── AssemblyInfo.cs
├── bin/
├── obj/
└── README.md                # Project documentation

Contributions 👥
This project was developed as a group effort. Each member is responsible for contributing to the final deliverable.

Team Members:
Gunther Santos
Erika Ortiz
Paola Lampe
Michael Smith
Yizhuo Hu
Contributions Needed:
Code improvement and optimization.
UI/UX enhancements.
Testing and debugging.
Please join the GitHub repository and make your commits to improve the final version of the project.

Screenshots 🖼️
