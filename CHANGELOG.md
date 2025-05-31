# Changelog

All notable changes to the Temperature Converter Console App will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Planned
- Add support for Rankine and Réaumur temperature scales
- Implement batch conversion from CSV file input
- Add configuration file for user preferences
- Create GUI version using WPF
- Add comprehensive unit test suite

## [1.2.0] - 2024-12-15

### Added
- Enhanced input validation with better error messages
- Support for decimal precision configuration
- Option to repeat conversions without restarting the application
- Clear screen functionality between conversions

### Changed
- Improved user interface with better formatting and colors
- Updated conversion formulas for higher precision
- Refactored code structure for better maintainability

### Fixed
- Fixed rounding errors in Kelvin conversions
- Corrected input validation for negative Kelvin temperatures
- Fixed application crash when entering non-numeric values

## [1.1.0] - 2024-11-20

### Added
- Interactive menu system for better user experience
- Input validation for temperature values and menu choices
- Support for negative temperature values
- Exit confirmation prompt

### Changed
- Reorganized code into separate classes for better modularity
- Improved error handling and user feedback
- Updated console output formatting

### Fixed
- Fixed infinite loop when invalid menu option is selected
- Corrected Fahrenheit to Kelvin conversion formula
- Fixed application hanging on invalid input

## [1.0.1] - 2024-11-05

### Fixed
- Fixed critical bug in Celsius to Fahrenheit conversion
- Corrected typos in user interface text
- Fixed application not closing properly on exit

### Changed
- Minor improvements to code comments and documentation

## [1.0.0] - 2024-10-28

### Added
- Initial release of Temperature Converter Console App
- Core temperature conversion functionality
- Support for Celsius, Fahrenheit, and Kelvin scales
- Basic console user interface
- Input validation for numeric values
- All six possible temperature conversions:
  - Celsius to Fahrenheit
  - Celsius to Kelvin
  - Fahrenheit to Celsius
  - Fahrenheit to Kelvin
  - Kelvin to Celsius
  - Kelvin to Fahrenheit

### Features
- Simple and intuitive command-line interface
- Accurate temperature conversion calculations
- Error handling for invalid inputs
- Cross-platform compatibility (.NET Core)

---

## Version History Summary

- **v1.2.0**: Enhanced user experience and precision improvements
- **v1.1.0**: Added interactive menu and input validation
- **v1.0.1**: Critical bug fixes and minor improvements
- **v1.0.0**: Initial release with core functionality

## Contributing to Changelog

When contributing to this project, please:

1. Add your changes to the "Unreleased" section
2. Follow the format: `### [Added/Changed/Fixed/Removed]`
3. Use present tense for descriptions
4. Include issue numbers when applicable
5. Move items from "Unreleased" to a new version section when releasing

## Changelog Categories

- **Added**: New features
- **Changed**: Changes in existing functionality
- **Deprecated**: Soon-to-be removed features
- **Removed**: Removed features
- **Fixed**: Bug fixes
- **Security**: Vulnerability fixes

---

*This changelog is automatically updated with each release. For the complete commit history, please visit the [GitHub repository](https://github.com/Mostafa-SAID7/Temperature-Converter-Console-App).*
