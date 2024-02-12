### Continuous Application Monitor

This C# program continuously monitors open applications on the system.

#### Main Method

- Entry point of the program.
- Continuously loops until the user presses 'q' to exit.
- Displays open applications, checks for processes that have exceeded the maximum allowed lifetime, and prompts the user to exit if desired.

#### DisplayOpenApplications Method

- Clears the console and prints the header for open applications.
- Retrieves all processes with non-empty window titles.
- Iterates through each process, calculates its lifetime, and prints application information including name, window title, and lifetime.

#### GetProcessesWithNonEmptyWindowTitles Method

- Retrieves all processes running on the system that have non-empty window titles.

#### GetLifetimeString Method

- Formats the lifetime of a process as a string in the format "X minutes, Y seconds".

#### CheckAndTerminateProcesses Method

- Retrieves all processes with non-empty window titles.
- Iterates through each process, calculates its lifetime, and terminates processes that have exceeded the maximum allowed lifetime.
- Terminated processes are logged with a message indicating the termination reason.

#### DisplayExitMessage Method

- Prints a message prompting the user to press 'q' to exit.

#### ShouldExit Method

- Checks if the 'q' key has been pressed by the user.
- Returns true if the 'q' key is pressed, indicating that the program should exit.

#### LogToFile Method

- Writes a message to a log file specified by LogFilePath.
- The log message includes the current date and time, along with the provided message.

#### LogToFile Method (internal)

- This method is not implemented and throws a NotImplementedException. It appears to be a leftover or incomplete method and is not used in the program.

Overall, this program provides a basic monitoring and termination mechanism for processes based on their lifetime. It also logs termination events to a log file for later reference.

---

### Setting Up a C# Project in Visual Studio Code

#### Install Required Software

- Ensure Visual Studio Code is installed on your system. If not, download it from the [official website](https://code.visualstudio.com/).
- Download .NET 8.0 :  [official website](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
- Install the C# extension for Visual Studio Code. Open Visual Studio Code, go to the Extensions view, search for "C#", and install the extension provided by Microsoft.

#### Create a New Folder for Your Project

- Create a new folder on your computer to store your C# project.

#### Open Visual Studio Code

- Open Visual Studio Code and navigate to the folder you created in the previous step.

#### Initialize Your Project

- Open the integrated terminal in Visual Studio Code and navigate to your project folder.
- Run the command `dotnet new console` to initialize a new C# console application project.

#### Open Your Project Files

- Once the project is created, you'll see the project files in the Explorer view of Visual Studio Code.
- Open `Program.cs` to start writing your C# code.

#### Build and Run Your Project

- Use the terminal in Visual Studio Code to navigate to your project folder.
- Run `dotnet build` to build your project.
- If there are no errors, run `dotnet run` to execute your application.

#### Debugging Your Project

- Visual Studio Code provides debugging support for C# projects. Set breakpoints in your code and use the debugging features provided by Visual Studio Code to debug your program.

#### Build and Run This Project

- You can clone this repository in your local machine.
> ```bash
>  git clone git@github.com:rcardosopereira/ChallengeVeeam.git
> ```
- Run dotnet build to build your project. Access the folder where your project is located ("cd ChallengeVeeam") and inside the ChallengeVeeam folder run the command below. Remember to access via terminal within VS Code.
> ```bash
>  dotnet build
> ```
- If there are no errors, run dotnet run to execute your application.
> ```bash
>  dotnet run
> ```
- For execute some test, run dotnet test.
> ```bash
>  dotnet test
> ```



### Support
Please, if you have some questions, feel free to write me. My e-mail is rcardosopereira@gmail.com
Thank you very much ;-)
