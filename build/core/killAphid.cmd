for /f "usebackq tokens=2,3 delims= " %%i in (`tasklist ^| findstr /r /i "^aphid.*\.exe"`) do (
    taskkill /pid %%i /f /t
)
