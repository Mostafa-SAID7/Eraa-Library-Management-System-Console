# Contributing to Temperature Converter Console App

Thank you for your interest in contributing to the Temperature Converter Console App! We welcome contributions from developers of all skill levels. This document provides guidelines and information on how to contribute effectively to this project.

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Getting Started](#getting-started)
- [How to Contribute](#how-to-contribute)
- [Development Setup](#development-setup)
- [Coding Standards](#coding-standards)
- [Commit Guidelines](#commit-guidelines)
- [Pull Request Process](#pull-request-process)
- [Issue Guidelines](#issue-guidelines)
- [Testing](#testing)
- [Documentation](#documentation)
- [Community](#community)

## Code of Conduct

This project and everyone participating in it is governed by our [Code of Conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code. Please report unacceptable behavior to the project maintainers.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- **.NET Core 3.1 or later**
- **Git** for version control
- **Visual Studio**, **Visual Studio Code**, or any C# compatible IDE
- **Basic knowledge** of C# programming language

### Fork and Clone

1. **Fork the repository** on GitHub
2. **Clone your fork** locally:
   ```bash
   git clone https://github.com/YOUR-USERNAME/Temperature-Converter-Console-App.git
   cd Temperature-Converter-Console-App
   ```
3. **Add the original repository** as upstream:
   ```bash
   git remote add upstream https://github.com/Mostafa-SAID7/Temperature-Converter-Console-App.git
   ```

## How to Contribute

There are many ways you can contribute to this project:

### 🐛 Bug Reports
- Report bugs through [GitHub Issues](https://github.com/Mostafa-SAID7/Temperature-Converter-Console-App/issues)
- Use the bug report template
- Include steps to reproduce, expected behavior, and actual behavior

### 💡 Feature Requests
- Suggest new features through [GitHub Issues](https://github.com/Mostafa-SAID7/Temperature-Converter-Console-App/issues)
- Use the feature request template
- Explain the use case and potential implementation

### 🔧 Code Contributions
- Fix bugs
- Implement new features
- Improve existing functionality
- Add tests
- Improve documentation

### 📚 Documentation
- Improve existing documentation
- Add code comments
- Create tutorials or examples
- Update README files

## Development Setup

1. **Clone and setup** the project as described in [Getting Started](#getting-started)

2. **Build the project**:
   ```bash
   dotnet build
   ```

3. **Run the application**:
   ```bash
   dotnet run
   ```

4. **Run tests** (when available):
   ```bash
   dotnet test
   ```

### Project Structure

```
Temperature-Converter-Console-App/
├── Program.cs                    # Main application entry point
├── TemperatureConverter.cs       # Core conversion logic
├── Models/                       # Data models (if applicable)
├── Services/                     # Business logic services
├── Tests/                        # Unit tests
├── docs/                         # Additional documentation
└── README.md                     # Project documentation
```

## Coding Standards

### C# Coding Conventions

Follow Microsoft's [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions):

#### Naming Conventions
```csharp
// Use PascalCase for classes, methods, and properties
public class TemperatureConverter
{
    public double ConvertCelsiusToFahrenheit(double celsius) { }
    public string UserInput { get; set; }
}

// Use camelCase for local variables and parameters
public void ProcessTemperature(double inputValue)
{
    double convertedValue = inputValue * 1.8 + 32;
}

// Use UPPER_CASE for constants
public const double ABSOLUTE_ZERO_CELSIUS = -273.15;
```

#### Code Organization
- **One class per file** with meaningful names
- **Methods should be focused** and do one thing well
- **Use meaningful variable names** that describe their purpose
- **Add XML documentation** for public methods and classes

#### Example of Well-Documented Code
```csharp
/// <summary>
/// Converts temperature from Celsius to Fahrenheit
/// </summary>
/// <param name="celsius">Temperature in Celsius</param>
/// <returns>Temperature in Fahrenheit</returns>
/// <exception cref="ArgumentException">Thrown when celsius is below absolute zero</exception>
public double ConvertCelsiusToFahrenheit(double celsius)
{
    if (celsius < ABSOLUTE_ZERO_CELSIUS)
        throw new ArgumentException("Temperature cannot be below absolute zero");
        
    return (celsius * 9.0 / 5.0) + 32.0;
}
```

### Code Quality Guidelines

- **Write clean, readable code** with proper indentation
- **Use meaningful comments** to explain complex logic
- **Handle exceptions appropriately** with try-catch blocks
- **Validate input parameters** before processing
- **Follow SOLID principles** where applicable
- **Write unit tests** for new functionality

## Commit Guidelines

### Commit Message Format

Use the following format for commit messages:

```
<type>(<scope>): <subject>

<body>

<footer>
```

#### Types
- **feat**: New feature
- **fix**: Bug fix
- **docs**: Documentation changes
- **style**: Code formatting changes
- **refactor**: Code refactoring
- **test**: Adding or updating tests
- **chore**: Maintenance tasks

#### Examples
```bash
feat(converter): add Kelvin to Rankine conversion

Add support for converting temperatures from Kelvin to Rankine scale.
Includes input validation and error handling.

Closes #15
```

```bash
fix(validation): handle negative Kelvin temperatures

Fix bug where negative Kelvin values were not properly validated.
Kelvin temperatures below absolute zero should throw an exception.

Fixes #23
```

## Pull Request Process

### Before Submitting

1. **Sync with upstream**:
   ```bash
   git fetch upstream
   git checkout main
   git merge upstream/main
   ```

2. **Create a feature branch**:
   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Make your changes** following the coding standards

4. **Test your changes** thoroughly

5. **Commit your changes** with clear commit messages

### Submitting the Pull Request

1. **Push your branch**:
   ```bash
   git push origin feature/your-feature-name
   ```

2. **Create a Pull Request** on GitHub with:
   - **Clear title** describing the change
   - **Detailed description** of what was changed and why
   - **Reference to related issues** (if applicable)
   - **Screenshots** (if UI changes are involved)

### Pull Request Template

```markdown
## Description
Brief description of changes made.

## Type of Change
- [ ] Bug fix
- [ ] New feature
- [ ] Documentation update
- [ ] Code refactoring

## Testing
- [ ] Tested locally
- [ ] Added unit tests
- [ ] Updated documentation

## Related Issues
Closes #[issue-number]

## Screenshots (if applicable)
Add screenshots here if relevant.
```

### Review Process

- **All PRs require review** before merging
- **Address reviewer feedback** promptly
- **Keep PRs focused** - one feature/fix per PR
- **Be responsive** to questions and suggestions

## Issue Guidelines

### Bug Reports

When reporting bugs, please include:

- **Clear title** summarizing the issue
- **Steps to reproduce** the bug
- **Expected behavior** vs **actual behavior**
- **System information** (OS, .NET version, etc.)
- **Screenshots** or error messages (if applicable)

### Feature Requests

When requesting features, please include:

- **Clear description** of the proposed feature
- **Use case** - why is this feature needed?
- **Acceptance criteria** - how will we know it's complete?
- **Possible implementation** ideas (optional)

### Issue Labels

We use the following labels to organize issues:

- **bug**: Something isn't working
- **enhancement**: New feature or improvement
- **documentation**: Documentation needs
- **good first issue**: Good for newcomers
- **help wanted**: Extra attention needed
- **question**: General questions

## Testing

### Writing Tests

- **Write unit tests** for new functionality
- **Test edge cases** and error conditions
- **Use descriptive test names** that explain what is being tested
- **Follow AAA pattern**: Arrange, Act, Assert

#### Example Test
```csharp
[Test]
public void ConvertCelsiusToFahrenheit_WithValidInput_ReturnsCorrectValue()
{
    // Arrange
    var converter = new TemperatureConverter();
    double celsius = 100.0;
    double expected = 212.0;

    // Act
    double result = converter.ConvertCelsiusToFahrenheit(celsius);

    // Assert
    Assert.AreEqual(expected, result, 0.001);
}
```

### Testing Checklist

- [ ] All existing tests pass
- [ ] New tests are added for new functionality
- [ ] Tests cover both success and failure scenarios
- [ ] Tests are well-documented and maintainable

## Documentation

### Documentation Standards

- **Keep documentation up-to-date** with code changes
- **Use clear, concise language**
- **Include code examples** where helpful
- **Document public APIs** with XML comments
- **Update README** when adding new features

### Documentation Types

- **Code Comments**: Explain complex logic
- **XML Documentation**: For public methods and classes
- **README Updates**: For new features or setup changes
- **Wiki Pages**: For detailed guides or tutorials

## Community

### Getting Help

- **GitHub Issues**: For bug reports and feature requests
- **GitHub Discussions**: For general questions and community chat
- **Email**: Contact maintainers directly for sensitive issues

### Recognition

Contributors will be recognized in:

- **README.md** contributors section
- **Release notes** for significant contributions
- **GitHub contributors** page

## Development Roadmap

### Current Priorities

1. **Unit Testing**: Add comprehensive test coverage
2. **Input Validation**: Improve error handling and validation
3. **Additional Scales**: Support for Rankine and Réaumur
4. **GUI Version**: Windows Forms or WPF interface

### Future Goals

- **Web API**: REST API for temperature conversions
- **Mobile App**: Cross-platform mobile application
- **Batch Processing**: File-based bulk conversions
- **Internationalization**: Multi-language support

## Questions?

If you have any questions about contributing, please:

1. **Check existing documentation** and issues first
2. **Open a new issue** with the "question" label
3. **Contact the maintainers** directly if needed

Thank you for contributing to the Temperature Converter Console App! 🌡️

---

**Happy Coding!** 🚀

*This document is a living guide and may be updated as the project evolves. Please check back regularly for updates.*
