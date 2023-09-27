# Api_Mvc
*DOTNET*

- dotnet help -> Lista opciones que tenes con dotnet
- dotnet ef -> Muestra la Version de Entity framework que esta usando
- dotnet ef --version -version de Entity framework
- dotnet watch run -> para levantar el proyecto

En caso de necesitar Certificado: 

- dotnet dev-certs https
- dotnet dev-certs https --trust

- dotnet add package -> Me instala el paquete que necesito 
Por defecto instala la ultima version..
- dotnet tool install --global dotnet-ef -> Instala la herramienta
- dotnet tool update --global dotnet-ef -> Actualiza entity

Paquetes nuget que se estan utilizando: 

- Microsoft.EntityFrameworkCore.SQLite
- Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore (Windows)
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer (Windows)

*Entity Framework*

- dotnet ef migrations add "Nombre de la migracion" -> Este comanmdo me crea la carpeta de migraciones
***OJO***
Cuando se haga la configuracion del connectionstring en el Archivo Programs.cs tiene que tener el var app = builder.Build(); tiene que estar debajo del conecttionString 
Fuente:
-> https://stackoverflow.com/questions/69959028/net-core-6-unable-to-resolve-service-for-type-while-attempting-to-activate


-  dotnet ef database update "Nombre de la migracion" -> Me crea la base de datos 



# Git
*En caso de que ignores la obj/bin*

- $ git rm --cached obj -r -> Me elimina todo de la carpeta obj
- $ git rm --cached obj -r -> Me elimina todo de la carpeta bin
