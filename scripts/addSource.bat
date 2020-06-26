c:\Build\.nuget\nuget sources add -Name Local -Source c:\Build\packages || goto end
%0\..\%1 %2

:end
exit /b %ERRORLEVEL%
