@echo off
set /p UserName=Please type in your steam username
echo %UserName%
set /p UserPassword=Please type in your steam password
echo %UserPassword%
dotnet DepotDownloader.dll -app 349040 -depot 349041 -manifest 1724464234984465664 -username %UserName% -password %UserPassword%