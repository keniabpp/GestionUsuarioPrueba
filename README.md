# Prueba de Conocimientos - Gestión de Usuarios

## Descripción
Este proyecto es una aplicación de ejemplo para la **gestión de usuarios**, desarrollada en **ASP.NET Web Forms** con **WCF** y **SQL Server**.  
Permite crear, consultar, modificar y eliminar usuarios, aplicando una **arquitectura por capas**:

- **Capa de Presentación:** Proyecto Web Forms (`Presentacion.Web`) con formularios de registro y consulta.  
- **Capa de Negocios:** Servicio WCF (`Negocio.WCF`) que implementa los métodos CRUD.  
- **Capa de Datos:** Base de datos SQL Server con tabla `Usuario` y procedimiento almacenado `SP_Usuario_CRUD`.

---

## Características
- Registro de usuarios con validaciones de campos obligatorios.  
- Consulta de usuarios en una grilla con opciones de **Modificar** y **Eliminar**.  
- Confirmaciones visuales al agregar, modificar o eliminar usuarios.  
- Estilo moderno con **Bootstrap** para formularios y grilla.  

---

## Requisitos
- Visual Studio 2019 o superior.  
- .NET Framework 4.8  
- SQL Server 2019 o superior.  
- Conexión configurada en `Web.config` bajo la clave `Conexion`.

---

## Estructura del proyecto
- `Presentacion.Web` – Contiene las páginas Web Forms (`Usuario.aspx`, `UsuarioConsulta.aspx`, `UsuarioModificar.aspx`).  
- `Negocio.WCF` – Contiene el servicio WCF (`UsuarioService.svc`) con los métodos `Agregar`, `Consultar`, `Modificar`, `Eliminar`.  
- `SQL` – Script para crear la base de datos, la tabla `Usuario` y el procedimiento almacenado `SP_Usuario_CRUD`.

---

## Uso
1. Ejecutar el script SQL para crear la base de datos `prueba` y la tabla `Usuario`.  
2. Configurar la cadena de conexión en `Web.config`.  
3. Ejecutar la solución en Visual Studio.  
4. Acceder a `Usuario.aspx` para crear usuarios.  
5. Acceder a `UsuarioConsulta.aspx` para ver, modificar o eliminar usuarios.

---

## Notas
- La columna de acciones en la grilla muestra los botones de **Modificar** y **Eliminar**.  
- Las fechas se muestran en formato `dd/MM/yyyy`.  
- La aplicación usa validaciones tanto en el formulario como en la capa de servicios.

---
