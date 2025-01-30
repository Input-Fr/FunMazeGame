@echo off
setlocal enabledelayedexpansion

:: Set the size threshold to 25MB (in bytes)
set SIZE_THRESHOLD=26214400  :: 25MB = 25 * 1024 * 1024

:: Loop through all files in the current directory and subdirectories
for /r %%f in (*) do (
    :: Get the size of the current file in bytes
    for %%s in ("%%f") do set SIZE=%%~zs
    
    :: Check if the file size is greater than the threshold (25MB)
    if !SIZE! gtr %SIZE_THRESHOLD% (
        :: Check if the file is already tracked by git lfs
        git lfs track --dry-run "%%f" | findstr /i "%%f" >nul
        if errorlevel 1 (
            echo Tracking large file: %%f
            git lfs track "%%f"
        )
    )
)

:: Stage changes to .gitattributes file
git add .gitattributes
echo Large files tracked and changes staged.
endlocal