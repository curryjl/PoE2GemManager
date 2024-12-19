# PoE2GemManager

PoE2GemManager is a WPF application designed to manage character classes and their associated gems in the game Path of Exile 2. The application is built using .NET 8 and C# 12.0.

## Features

- Manage character classes
- Dynamic UI updates using `ObservableCollection<T>`
- Split window functionality for enhanced user experience

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET 8 SDK

### Installation

1. Clone the repository:
git clone https://github.com/yourusername/PoE2GemManager.git

2. Open the solution file `PoE2GemManager.sln` in Visual Studio 2022.

3. Restore the NuGet packages:
dotnet restore

4. Build the solution:
dotnet build  

### Running the Application

1. Set `PoE2GemManager` as the startup project.
2. Press `F5` or click on the `Start` button in Visual Studio to run the application.

## Project Structure

- `PoE2GemManager/Models`: Contains the data models used in the application.
- `PoE2GemManager/ViewModels`: Contains the view models, including `CharacterClassViewModel`.
- `PoE2GemManager/Views`: Contains the XAML files for the main window and secondary window.
- `PoE2GemManager/App.xaml`: Application definition and resources.
- `PoE2GemManager/MainWindow.xaml`: Main window of the application.
- `PoE2GemManager/SecondaryWindow.xaml`: Secondary window for additional functionality.

## Usage

### Managing Character Classes

The `CharacterClassViewModel` class manages a collection of character classes using an `ObservableCollection<CharacterClass>`. This allows the UI to dynamically update when the collection changes.

### Split Window Functionality

The application demonstrates how to split the main window into two separate windows and how to have a dropdown in one window trigger behavior in the other window.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- Path of Exile 2 for inspiration
- Microsoft for the .NET framework and Visual Studio
   