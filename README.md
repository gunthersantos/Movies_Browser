Movie Browser Application 🎬
Project Overview
This project is a Movie Browser Application developed for the Rapid Application Development course. The application allows users to search for movies, view detailed information, and manage a watchlist. The project integrates with the OMDb API to fetch real-time movie data and provides a user-friendly interface built with Windows Forms in C#.

Features 🚀
Search Movies: Search for movies using keywords and retrieve a list of results.
View Movie Details: Display detailed information about a selected movie, including title, year, genre, plot, and poster.
Watchlist Management: Add movies to a personalized watchlist.
Responsive UI: A clean and functional Windows Forms interface with proper layout management.
Technologies Used 🛠️
Programming Language: C#
Framework: Windows Forms (.NET Framework)
API Integration: OMDb API (OMDb API Documentation)
JSON Parsing: Newtonsoft.Json
How to Run the Project ⚡
Clone the repository to your local machine.
bash
Copiar código
git clone https://github.com/your-repository-url.git
Open the solution file (.sln) in Visual Studio.
Install dependencies:
Newtonsoft.Json
System.Net.Http (already included in .NET Framework).
Replace the placeholder apiKey in the MovieAPIService class with your own OMDb API key.
Build the project by selecting Build > Rebuild Solution in Visual Studio.
Run the application by pressing F5 or selecting Debug > Start Debugging.
Project Structure 📂
plaintext
Copiar código
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

Erika
[Your Name]
[Other Members]
Contributions Needed:
Code improvement and optimization.
UI/UX enhancements.
Testing and debugging.
Please join the GitHub repository and make your commits to improve the final version of the project.

Screenshots 🖼️
Include some screenshots here to showcase the application.

![image](https://github.com/user-attachments/assets/3d13cc27-5dae-4388-83ac-e985c6560c2b)
