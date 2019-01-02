# heic 2 jpg

This tool lets you convert all .heic image files in a folder to .jpg format.
Dependencies are:
* [Git client](https://git-scm.com/download) to get the code
* [.NET Core 2.1 SDK or greater](https://dotnet.microsoft.com/download) to run the code

There are two ways to execute it:

* Clone this repo, open a command line in the "/Heic2Jpg" subfolder and call 'dotnet run -- path\to\folder\containing\heics'
* Open a PowerShell in the folder where your .heic files are located, and call . { iwr -useb https://raw.githubusercontent.com/ChristianEder/heic-2-jpg/master/convert-remote.ps1 -Headers @{"Cache-Control"="no-cache"} } | iex;
  * this will convert all .heic files in the current directory and its subdirectories to .jpg format, and delete the source .heic files
  * this requires Set-ExecutionPolicy -ExecutionPolicy Unrestricted
