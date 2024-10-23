# Coderland BackEnd Challenge

Este es un proyecto backend desarrollado en **ASP.NET Core** con **Entity Framework Core** y **PostgreSQL** para la base de datos. El propósito de esta aplicación es gestionar una tabla de marcas de autos (**MarcasAutos**) y proporcionar una API REST para consumir estos datos.

## Tecnologías Utilizadas

- **.NET 8.0**
- **ASP.NET Core**
- **Entity Framework Core**
- **PostgreSQL**
- **Docker** y **Docker Compose**

---

## Requisitos Previos

Para poder ejecutar este proyecto en tu máquina, necesitas tener instaladas las siguientes herramientas:

- **Docker**: [Instalar Docker](https://docs.docker.com/get-docker/)
- **Docker Compose**: [Instalar Docker Compose](https://docs.docker.com/compose/install/)

---

## Configuración de la Base de Datos

El proyecto utiliza **PostgreSQL** como base de datos. La configuración de la cadena de conexión para la base de datos se encuentra en el archivo `appsettings.json`. Aquí tienes un ejemplo de la cadena de conexión utilizada:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=db;Port=5432;Database=MarcasAutosDB;Username=postgres;Password=panda2011"
  }
}
Host=db: Apunta al servicio db definido en docker-compose.yml.
Port=5432: Puerto donde PostgreSQL está escuchando.
Database=MarcasAutosDB: Nombre de la base de datos.
Username=postgres y Password=panda2011: Credenciales de PostgreSQL.
Cómo Ejecutar el Proyecto
El proyecto está configurado para ejecutarse con Docker Compose, lo que facilita levantar tanto la API como la base de datos en contenedores Docker.

Pasos para ejecutar el proyecto:
Clonar el repositorio

Si aún no tienes el proyecto, clónalo desde el repositorio:

bash
Copiar código
git clone <URL_DEL_REPOSITORIO>
cd Coderland_BackEnd_Challenge
Construir y ejecutar los contenedores con Docker Compose

Docker Compose se encargará de construir las imágenes y levantar tanto la API como la base de datos PostgreSQL. Para ello, ejecuta:

bash
Copiar código
docker-compose up --build
Verificar que los contenedores están en ejecución

Para verificar que los contenedores se están ejecutando correctamente, puedes usar el siguiente comando:

bash
Copiar código
docker ps
Deberías ver los contenedores api y db en ejecución.

Acceder a la API

La API estará disponible en http://localhost:8080. Puedes probar los endpoints en tu navegador o usando herramientas como Postman o curl.

Por ejemplo, para obtener todas las marcas de autos, puedes hacer una petición a:

bash
Copiar código
http://localhost:8080/api/MarcasAutos
Ejecutar Migraciones de la Base de Datos
Las migraciones se ejecutan automáticamente cuando se levanta el contenedor de la API. Sin embargo, si necesitas ejecutarlas manualmente, puedes hacerlo dentro del contenedor.

Conectarte al contenedor de la API:

bash
Copiar código
docker exec -it <api_container_id> /bin/bash
Ejecutar las migraciones manualmente:

bash
Copiar código
dotnet ef database update
Parar los Contenedores
Para detener los contenedores en ejecución, puedes ejecutar:

bash
Copiar código
docker-compose down
Notas
Asegúrate de que Docker y Docker Compose estén correctamente instalados y en funcionamiento antes de intentar ejecutar el proyecto.
Puedes verificar los logs de los contenedores si surge algún problema:
bash
Copiar código
docker logs <container_id>
Contacto
Para cualquier duda o consulta, puedes contactar a tu_email@dominio.com.

go
Copiar código

Este es el archivo en formato Markdown, que puedes copiar y pegar directamente en tu archivo **`README.md`** en tu proyecto. ¡Listo para ser usado!


//Readme hecho por chatgpt porque se me acabó el tiempo


