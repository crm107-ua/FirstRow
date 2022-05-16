# FirstRow
## _Travel Agency - Making dreams_ 
## http://www.firstrow.es 

[![N|Solid](https://www.lesly.es/images/playlists/6433450.png)](https://github.com/crm107-ua/FirstRow)

## Descripción

###### FirstRow es una agencia de viajes online. Esta plataforma  proporciona y organiza viajes alrededor de todo el mundo, a la vez que da la oportunidad de compartir las experiencias de sus usuarios mediante galerías de imágenes, blogs, stories y muchas otras más funciones

###
### 
 
###### El esquema relacional de la base de datos junto con el de sql server y el boceto inicial estan situados en la raíz del repositorio, en un pdf llamado "Esquema_BBDD.pdf". 

###
###

## Parte pública

###### Esta sección de la plataforma será pública. No será necesario estar registrado para observar el contenido.

- Esta parte de la plataforma podrá ser visitada por:
    - Cualquier usuario
- Constará de las siguientes funcionalidades:
    - Observar y consumir contenido con opciones de filtro en:
        -  Viajes: tours disponibles ordenados por países. 
        -  Galerías de imágenes: imágenes de tours, blogs y experiencias de usuarios
        -  Stories: imágenes con duración limitada de momentos de los usuarios
        -  Comentarios: de viajes y blogs
        -  Wearing: información sobre la vestimenta adecuada para cada viaje
        -  Blogs: información sobre temas de viajes junto con imágenes y referencias
        -  Ver últimos sorteos: listas de sorteos que realiza la plataforma
        -  Contacto: ficha con datos de contacto de la plataforma
        -  Información de página: paginas de requisitos legales y mas información
    - Se podrán inicializar procesos de reserva de viajes por lo usuarios
    - Se tendrá acceso a las redes sociales de la plataforma
    - Lista de destinos, lugares y países disponibles

###
###

## Listado EN Pública

###### Listado de entidades lógicas relacionadas con la parte pública de la plataforma

- Usuarios
- Viajes
- Storie
- Seccion_Galeria
- Blog
- Comentarios
- Categorias
- Sorteos
- Wearing

## Parte privada

###### Esta sección de la plataforma será privada. Será necesario estar registrado para observar el contenido.

- Esta parte de la plataforma podrá ser visitada por:
    - Clientes
    - Empresas
    - Administrador
- Constará de las siguientes funcionalidades:
    - Funcionalidad de empresa en dashboard
        -  Agregar, modificar o eliminar viajes
        -  Agregar, modificar o eliminar secciones de galería
        -  Agregar, modificar o eliminar blogs
        -  Agregar, modificar o eliminar sorteos
        -  Agregar, modificar o eliminar wearing
        -  Visor de estadísticas disponibles en:
            - Ventas de viajes
            - Comentarios relacionados con su marca
            - Propuestas de los usuarios
            - Comentarios de los usuarios en cada uno de sus viajes
    - Funcionalidad de clientes
        -  Reserva de viajes en una fecha
        -  Agregar, modificar o eliminar secciones de galería
        -  Agregar, modificar o eliminar blogs
        -  Agregar, modificar o eliminar stories
        -  Agregar, modificar o eliminar sorteos
        -  Agregar, modificar o eliminar comentarios
        -  Agregar, modificar o eliminar propuestas
        -  Agregar, modificar o eliminar wearing
        -  Participación en sorteos
    - Funcionalidad del administrador
        -  Modificación dinámica de información e imágenes de la página principal
        -  Modificación dinámica de información e imagen principal en viajes
        -  Modificación dinámica de información en stories
        -  Modificación dinámica de información en galería
        -  Modificación dinámica de información en blog
        -  Agregar o eliminar países
        -  Agregar, modificar o eliminar categorias
        -  Modificar o eliminar comentarios inapropiados
        -  Modificar o eliminar propuestas inapropiadas
        -  Control del flujo total de usuarios, tanto clientes como empresas
        
###
###

## Listado EN Privada

###### Listado de entidades lógicas relacionadas con la parte privada de la plataforma

- Usuarios
- Viajes
- Reservas
- Storie
- Seccion_Galeria
- Blog
- Comentarios
- Categorias
- Propuestas
- Sorteos
- Wearing
- Administración

###
###

## Posibles mejoras

###### En la siguiente sección se proporciona una lista de las posibles mejoras que se pueden implementar en la aplicación

- Mejoras en funcionalidad de empresa
    - Implementación de gráficas personalizables en:
        - Usuarios asociados a actividades (sorteos, propuestas, comentarios) de la empresa
        - Viajes
        - Ventas
        - Participación en sorteos
        - Acceso a redes
    - Implementación de una tienda
    ###
 - Mejoras de funcionalidad en usuario
    - Implementación de un sistema de recomendaciones que aprenda sobre el comportamiento de los usuarios en la plataforma, para que posteriormente les proporcione viajes más acordes a sus gustos y presupuesto.
    - Implementación de hilos para que la plataforma conozca todos los recorridos que realizan los usuarios en la misma, junto con el orden en el que se van visitando cada uno de sus apartados. El objetivo debe ser proporcionar a la empresa la mayor cantidad de datos sobre lo que más visita un usuario a partir de sus viajes y experiencias.
    ###
 - Mejoras de funcionalidad en administrador
    -  Automatización de cambio de imágenes e información en los apartados genéricos cada cierto tiempo.
    -  Mostrar en la página principal las imágenes y los comentarios mejor valorados.
    -  Optimizador de búsqueda de contenido en función de cookies del usuario.
    -  Servicio de chat y asistencia entre empresas y clientes 24 horas.










