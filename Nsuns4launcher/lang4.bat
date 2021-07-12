@echo off
set /p UserName=Please type in your steam username
echo %UserName%
set /p UserPassword=Please type in your steam password
echo %UserPassword%
dotnet DepotDownloader.dll -app 349040 -depot 349044 -manifest 4370769991278716701 -username %UserName% -password %UserPassword%