# Api_Mvc

dotnet help -> Lista opciones que tenes con dotnet
dotnet ef -> Muestra la Version de Entity framework que esta usando
dotnet ef --version -version de Entity framework
dotnet watch run -> para levantar el proyecto

dotnet add package -> Me instala el paquete que necesito 
Por defecto instala la ultima version
dotnet tool install --global dotnet-ef -> Instala la herramienta
dotnet tool update --global dotnet-ef -> Actualiza entity

Paquetes nuget que se estan utilizando: 

- Microsoft.EntityFrameworkCore.SQLite
- Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore (Windows)
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer (Windows)


En caso de necesitar Certificado: 
- dotnet dev-certs https
- dotnet dev-certs https --trust



# Git
*En caso de que ignores la obj/bin*
$ git rm --cached obj -r -> Me elimina todo de la carpeta obj

$ git rm --cached obj -r -> Me elimina todo de la carpeta bin
