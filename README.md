INSTRUCCIONES
Se necesita correr el script que esta dentro de la carpeta script para generar la base de datos, la tabla e insertar algunos datos.
Luego, hay que cambiar la cadena de conexion que esta en DAO->UserDAO y apuntar a la base creada.
Hecho esto ya se puede correr la aplicacion



Test Genérico de .NET:

Necesitaríamos que crees una aplicación en Visual Studio 2015 framework 4.5.2 del tipo REST Web Api que exponga dos servicios:

1) Un servicio "cotización" que sea llamado con los parámetros de la moneda ej: http://localhost:8080/MyResftfullApp/Cotizacion/MONEDA, donde MONEDA podría ser "Dolar", "Pesos", "Real"; implementando el patrón Strategy para consumir los diferentes servicios.

Para los parámetros Pesos y Real, implementar un servicio que de una respuesta que sea error 401 no authorized de http. Para el parámetro Dólar implementar un servicio que consuma la cotización del dólar actual desde el servicio externo: http://www.bancoprovincia.com.ar/Principal/Dolar

2) Crear un servicio "usuarios" que devuelva todos los usuarios de una tabla "User" con los campos, id, nombre, apellido, email, password. Para esto deberás crear la base de datos, la tabla, popular con un script y empaquetar todos los datos necesarios para poder correr en otra computadora la aplicación y los servicios.

3) Crear los servicios en la api rest para el ABM de usuarios

4) Crear unit test para la capa de servicios interna.

Necesitamos el código fuente, instrucciones y script para generar la base de datos y popularla con datos de prueba.

5 )Subir el proyecto a github
