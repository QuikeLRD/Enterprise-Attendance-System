# Sistema de Registro de Asistencia Empresarial – C# (Windows Forms)

##  Descripción del Proyecto
Este proyecto fue desarrollado como **proyecto final** de la materia de Programación Avanzada.  
Es una **aplicación de escritorio en C#** diseñada para gestionar la asistencia de empleados y las solicitudes de materiales dentro de una empresa.  

El sistema integra **interfaz gráfica (GUI), escaneo de códigos QR, detección de color, manejo de base de datos en archivos de texto y generación de tickets**, simulando un flujo de trabajo real.  

---

## ⚙️ Funcionalidades
- **Autenticación de empleados:** Inicio de sesión con número de cuenta y validación de departamento.  
- **Registro de asistencia:** Los empleados registran su entrada mediante escaneo de código QR.  
- **Solicitud de materiales:** Permite a los usuarios solicitar materiales, validando permisos según su departamento.  
- **Generación de tickets:** Crea automáticamente archivos `.txt` con datos del empleado, detalle de la operación, fecha y hora.  
- **Manejo de base de datos:** Utiliza archivos de texto para almacenar empleados y transacciones.  
- **Interfaz gráfica:** Desarrollada en Windows Forms con estilo de **MaterialSkin**.  
- **Procesamiento de imágenes:** Implementado con **OpenCvSharp** para detección de color/QR y **ZXing.Net** para decodificación de códigos QR.  

---

##  Mi Contribución
Este fue un **proyecto en equipo (4 integrantes)**.  
Mi rol específico fue desarrollar el **módulo de impresión de tickets**:  
- Implementación de generación de tickets con `StreamWriter` en formato `.txt`.  
- Manejo de errores y notificaciones emergentes.  
- Integración del sistema de tickets con los módulos de asistencia y solicitudes.  

---

##  Resultados
- Probado exitosamente con 5 departamentos (Administración, Finanzas, Jardinería, Limpieza, Dirección).  
- Automatización de procesos de asistencia y solicitudes de materiales.  
- Generación de **reportes y registros históricos** mediante tickets.  


---

## 🛠️ Tecnologías Utilizadas
- **Lenguaje:** C# (Windows Forms)  
- **Librerías:** OpenCvSharp4, ZXing.Net, MaterialSkin  
- **Herramientas:** Visual Studio, .NET Framework  

---

## 📂 Estructura del Repositorio
📁 EnterpriseAttendanceSystem
┣ 📂 src/ # Código fuente principal
┣ 📂 data/ # Base de datos de empleados y transacciones (archivos de texto)
┣ 📂 tickets/ # Tickets generados
┗ README.md # Documentación del proyecto
