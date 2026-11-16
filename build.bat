@echo off
setlocal
cd /d "%~dp0"
title GitHub Farm - build

set "CSC=%WINDIR%\Microsoft.NET\Framework64\v4.0.30319\csc.exe"
if not exist "%CSC%" set "CSC=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\csc.exe"
if not exist "%CSC%" (
    echo Could not find the .NET Framework C# compiler [csc.exe] on this PC.
    pause
    exit /b 1
)
if not exist "GitHubFarm.cs" (
    echo GitHubFarm.cs is not next to build.bat.
    pause
    exit /b 1
)

tasklist /fi "imagename eq GitHubFarm.exe" 2>nul | find /i "GitHubFarm.exe" >nul
if not errorlevel 1 (
    echo GitHubFarm.exe is still running, closing it so it can be rebuilt ...
    taskkill /f /t /im GitHubFarm.exe >nul 2>nul
    timeout /t 2 /nobreak >nul
)

echo Building GitHubFarm.exe ...
"%CSC%" /nologo /target:winexe /r:System.Web.Extensions.dll /out:GitHubFarm.exe GitHubFarm.cs
if errorlevel 1 (
    echo.
    echo BUILD FAILED - read the errors above. If GitHubFarm.exe is open, close it and run this again.
    pause
    exit /b 1
)
echo.
echo Build OK: %~dp0GitHubFarm.exe
echo.

choice /c YN /n /m "Run the offline self-test now? It never touches GitHub and can take a few minutes [Y/N] "
if errorlevel 2 (
    echo Self-test skipped.
) else (
    where git >nul 2>nul
    if errorlevel 1 (
        echo Git is not installed, so the self-test cannot run. Get it from https://git-scm.com
    ) else (
        echo Running self-test, please wait. Progress is written to selftest-result.txt while it runs.
        if exist selftest-result.txt del selftest-result.txt
        start "" /wait "%~dp0GitHubFarm.exe" --selftest "%~dp0selftest-result.txt"
        echo.
        if exist selftest-result.txt (
            type selftest-result.txt
        ) else (
            echo The self-test did not write a result file.
        )
    )
)

echo.
echo Finished. Start GitHubFarm.exe to use the app.
pause
