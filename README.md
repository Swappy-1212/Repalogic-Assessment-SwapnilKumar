# Application Setup & Run Guide

## Prerequisites

Before running this application, make sure you have the following installed:

* **An IDE** that supports **ASP.NET Core with C#**, such as:

  * Visual Studio (recommended)
  * Visual Studio Code
  * JetBrains Rider or any compatible IDE
* **.NET SDK** (matching the version used by the project)

  * You can verify installation by running:

    ```bash
    dotnet --version
    ```

## Getting Started

1. **Clone the repository**

   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```

2. **Open the project**

   * Open the solution file (`.sln`) in **Visual Studio**, or
   * Open the project folder in **Visual Studio Code** or your preferred IDE

3. **Restore dependencies**

   ```bash
   dotnet restore
   ```

4. **Build the application**

   ```bash
   dotnet build
   ```

5. **Run the application**

   ```bash
   dotnet run
   ```

   * The application will start and display the local URL (for example: `https://localhost:5001`)

## Configuration

* Application settings can be found in `appsettings.json`
* Environment-specific settings can be configured using:

  * `appsettings.Development.json`
  * `appsettings.Production.json`

## Notes & Recommendations

* Ensure the correct **.NET SDK version** is installed to avoid build errors
* If using **Visual Studio Code**, install the following extensions:

  * C# (by Microsoft)
  * .NET Install Tool (optional but helpful)
* Run the application in **Development mode** for debugging
* If ports are blocked or already in use, update the launch settings in `Properties/launchSettings.json`

## Troubleshooting

* If you encounter restore or build issues, try:

  ```bash
  dotnet clean
  dotnet restore
  dotnet build
  ```
* Make sure no firewall or antivirus software is blocking the application

---

You're all set! 🚀 The application should now be running locally.
