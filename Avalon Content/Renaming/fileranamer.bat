setlocal enabledelayedexpansion
set "count=327"
for /f "delims=*" %%f in ('dir /b /o:-d /tc *.xnb') do (
    ren %%f Buff_!count!.xnb
    set /a count+=1
)