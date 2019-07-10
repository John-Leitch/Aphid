@echo off
pushd .
cd /d %~dp0..
for /F %%i IN ('dir /s bin /ad /b') DO rd /s /q %%i 
for /F %%i IN ('dir /s obj /ad /b') DO rd /s /q %%i 
del /s *.cache*
del /s *.cache* /ah
popd
@echo on