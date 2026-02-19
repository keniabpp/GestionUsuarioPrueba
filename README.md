## Configuración y ejecución

### 1️⃣ Configuración inicial

1. Ejecutar el script SQL ubicado en la carpeta `SQL` para crear la base de datos `prueba`, la tabla `Usuario` y el procedimiento almacenado `SP_Usuario_CRUD`.
2. Configurar la cadena de conexión en el archivo `Web.config` del proyecto `Negocio.WCF` bajo la clave `Conexion`.

---

### 2️⃣ Ejecutar el proyecto en Visual Studio

1. Abrir la solución (`.sln`) en Visual Studio.
2. Hacer clic derecho sobre la **solución** (no sobre un proyecto).
3. Seleccionar **Propiedades**.
4. Ir a la opción **Proyectos de inicio**.
5. Seleccionar **Varios proyectos de inicio**.
6. En la columna **Acción**, seleccionar **Iniciar** para:
   - `Negocio.WCF`
   - `Presentacion.Web`
7. Hacer clic en **Aplicar** y luego en **Aceptar**.
8. Presionar el botón verde **Iniciar** (▶).

Una vez se abra el navegador:

- Acceder a `Usuario.aspx` para crear usuarios.
- Acceder a `UsuarioConsulta.aspx` para consultar, modificar o eliminar registros.