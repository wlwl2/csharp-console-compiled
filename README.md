# Basic C# Console App (Compiled)

Basic C# console app (with instructions on how to compile it and use the compiled version).

## VS Code

Go to root folder and run:

`dotnet run one two three`

## Developer Command Prompt (Visual Studio)

Open Developer Command Prompt for VS2015 (or some other version e.g. VS2017).

You can go to root folder and run:

`dotnet run one two three`

### Compile

Go to the root/main folder (where this project is located):

`csc Program.cs`

To run in PowerShell:

`./Program.exe one two "three 3"`

To run in command prompt:

`Program.exe one two "three 3"`

add quotation marks for spaces

https://stackoverflow.com/questions/552796/what-is-string-args-in-main-class-for

The parameters are optional in C# if your application does not use command line arguments.
