# Advanced Library Management System Console App
## Author

**Mostafa SAID**  
- GitHub: [@Mostafa-SAID7](https://github.com/Mostafa-SAID7)


A comprehensive console-based library management system built in C# that allows users to register, login, borrow, return, and manage books with advanced features including admin controls, overdue tracking, and fine calculation.

## Features

- **User Authentication**: Register and login with username and password  
- **Admin Controls**: Add books, view all users, manage library  
- **Book Management**: Borrow, return, and view available or borrowed books  
- **Overdue Tracking**: Calculate overdue days and fines on late returns  
- **Persistent Storage**: Saves users and books data to JSON files  
- **Clean Modular Structure**: Code organized into Models, Services, and Program entry point  
- **Console-Based UI**: Interactive command line menus for ease of use  

## Installation

### Prerequisites
- .NET Core 3.1 or later
- Any C# compatible IDE (Visual Studio, Visual Studio Code, JetBrains Rider, etc.)

### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/AdvancedLibraryManagementSystem.git
Navigate to the project directory:

cd AdvancedLibraryManagementSystem

Build the project:
```
dotnet build
Run the application:
dotnet run
```
### Project Structure
```
AdvancedLibraryManagementSystem/
├── Program.cs                # Main application entry point and UI menus
├── Models/
│   ├── Book.cs              # Book data model
│   └── User.cs              # User data model
├── Services/
│   ├── Library.cs           # Core library logic (book management)
│   └── UserManager.cs       # User authentication and management
└── Data/
    ├── books.json           # Persistent book data
    └── users.json           # Persistent user data
```
##### Usage

- On first run, an admin user is created automatically (`admin` / `admin`)  
- Admins can add new books and view all users  
- Regular users can register, login, borrow, return, and view books  
- Returning books after due date calculates overdue fines ($1 per day)  


### ## Future Enhancements

- [ ] Implement password hashing for secure authentication  
- [ ] Add search and filter functionality for books  
- [ ] Enable book reservation and waitlists  
- [ ] Create GUI version using WPF or Windows Forms  
- [ ] Add unit tests for core functionalities  
- [ ] Support multiple user roles with granular permissions  

## License

This project is open source and available under the [MIT License](https://opensource.org/licenses/MIT).


Author
Your Name

GitHub: @yourusername

## Acknowledgments

- Inspired by classic library management systems and C# console app tutorials  
- Thanks to the [.NET Community](https://dotnet.microsoft.com/community) for great resources and support  
