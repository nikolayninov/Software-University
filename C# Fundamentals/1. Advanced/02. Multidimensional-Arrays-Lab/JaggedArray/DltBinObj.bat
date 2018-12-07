FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin') DO Del /S /Q "%%G" &&
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj') DO Del /S /Q "%%G" &&
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj') DO rm /S /Q "%%G"