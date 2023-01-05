This application is a quick test app for GestForm test.

- Installation and usage:

The application runs with .NET framework under version 7.0.101 : https://dotnet.microsoft.com/en-us/

To run the program, assuming .NET is installed and accessible through a terminal, in app directory, use: dotnet run -- arglist

- Examples
dotnet run -- 3 5 30 65 4 will print

Geste
Forme
Gestform
Forme
4

If an argument is not numeric, the program will stop looping over the arguments and show a message:

dotnet run -- arg

One of your arguments is not a number, please enter only numeric arguments.
Argument recieved: arg

If an argument is out of bounds, the program will stop looping over the arguments and show a message:
Note: bounds for arguments are between -1000 and 1000.

dotnet run -- 1001

One of your arguments is invalid. Please enter a number between -1000 and 1000 included
Argument recieved: 1001

A final note, if the list is composed of a number of valid arguments, and an invalid one, the application will display results for the valid arguments untils it encounters the invalid entry. The following numbers are not displayed.