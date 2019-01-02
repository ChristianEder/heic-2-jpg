# heic 2 jpg

This tool lets you convert all .heic image files in a folder to .jpg format.

There are two ways to execute it:

* Clone this repo, open a PowerShell and call .\convert.ps1 "path\to\folder\containing\heics"
* Open a PowerShell in the folder where your .heic files are located, and call . { iwr -useb https://raw.githubusercontent.com/ChristianEder/heic-2-jpg/master/convert-remote.ps1 -Headers @{"Cache-Control"="no-cache"} } | iex;
  * this will convert all .heic files in the current directory and its subdirectories to .jpg format, and delete the source .heic files
  * this requires Set-ExecutionPolicy -ExecutionPolicy Unrestricted
