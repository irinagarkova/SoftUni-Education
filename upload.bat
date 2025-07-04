@echo off
cd /d %~dp0

git init


git config user.name "irinagarkova"
git config user.email "irinagarkova85@gmail.com"


git remote remove origin 2>nul
git remote add origin https://github.com/irinagarkova/SoftUni-Education.git


git branch -M main

for /f "delims=" %%a in ('dir /b /ad /o:d') do (
    echo Added folder: %%a
    git add "%%a"
    git commit -m "%%a"
)

if exist ".gitignore" (
    git add .gitignore
    git commit -m "ADDED .gitignore"
)

for %%I in ("%cd%") do set CurrDirName=%%~nxI
git add .
git commit -m "%CurrDirName%"


git push -u origin main

pause

