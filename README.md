# DemoMicroserviceSolution
<p>Proyecto de microservicios con distintas bases de datos por cada uno de ellos. Servicio ApiGateway con Ocelot unificando todas las rutar por un unico endpoint.</p>
<p>Basado en el tutorial de **Learn Microservice Architecture** [Coding Droplets](https://www.youtube.com/c/CodingDroplets)</p>


## CustomerWebApi
**Customers:** Proyecto simple que representa a vendedores y es gestionado con una base de datos SQL Server.
## ProductWebApi
**Products:** Proyecto simple que representa a Productos. Es gestionado con una base de datos MySQL.
## OrderWebApi
**Orders:** Proyecto simple que representa a pedidos. Es gestionado con una base de datos Mongo.

## ApiGateway
**Ocelot:** Se encarga de unificar todos los endpoints en uno único.