# Microsoft Dev Group Cobán - Sesión #3
## Entity Framework Core y LINQ

Repositorio con ejemplos de Entity Framework, serán necesario levantar un contenedor según se explica a continuación:

## **Requisitos**  
Contenedor de la Base de Datos "crobles10/hr-database:20.0" proporcionado por [Carlos Robles](https://github.com/dbamaster)
    
	docker run --name hr_sql_dev --network=default --hostname hr_sql_dev --publish 1433:1433 --detach crobles10/hr-database:20.0

También pueden lanzar el contenedor mediante el archivo de Docker Compose que se agrega al repositorio:

    docker-compose up -d

Credenciales de acceso:

    Base de datos: HumanResources
    Usuario: SA
    Contraseña: _SqLr0ck$_

## Síguenos
[![N|Solid](../img/fb_icon.png)](https://www.facebook.com/groups/MsDevGroupCoban/)