# Luz-Verde-Academia
## Proyecto de sistema de gestión de la Academia de Choferes Luz Verde

1. Clase Alumno
Responsabilidades:
Gestionar la información de los alumnos (nombre, email, Instagram).
Almacenar el historial de clases que ha tomado cada alumno.
Atributos:
Nombre.
Email.
Instagram.
Historial de clases.

3. Clase Instructor
Responsabilidades:
Almacenar la información de los instructores.
Asignar los autos a cada instructor.
Gestionar los horarios disponibles y cumplidos.
Atributos:
Nombre.
Auto (que puede repetirse entre instructores).
Horarios disponibles.
Horarios de clases cumplidos.

5. Clase Auto
Responsabilidades:
Identificar cada vehículo (autos o camiones).
Asignar disponibilidad y uso para clases.
Atributos:
Modelo.
Tipo (auto, camión).
Matrícula.
Instructor responsable (puede repetirse).

7. Clase Clase
Responsabilidades:
Registrar la información de cada clase (fecha, horario, auto, instructor).
Asignar los alumnos a las clases.
Atributos:
Fecha y hora.
Auto.
Instructor.
Alumnos.

9. Clase Usuario
Responsabilidades:
Gestionar los diferentes niveles de acceso al sistema.
Almacenar la información del usuario.
Realizar acciones según el rol (dueño, responsables).
Atributos:
Nombre.
Email.
Rol (dueño, responsable).
Acceso a las funciones del sistema (lectura, escritura).

11. Clase Transaccion
Responsabilidades:
Registrar todas las entradas de dinero (pagos de alumnos).
Gestionar los sueldos a pagar a los instructores.
Calcular el balance total de la academia.
Atributos:
Monto.
Tipo (entrada/salida).
Fecha.
Descripción (pago de clase, sueldo, etc.).

13. Clase Academia
Responsabilidades:
Gestionar la información de la academia.
Conocer todos los alumnos, instructores, autos y clases.
Mantener el registro de transacciones financieras (entradas y sueldos).
Supervisar el balance financiero.
Atributos:
Lista de alumnos.
Lista de instructores.
Lista de autos.
Lista de clases.
Lista de usuarios.
Balance financiero.

14. Clase Horarios
Responsabilidades:
Definir y gestionar los horarios disponibles de los instructores y autos.
Controlar los horarios ocupados y cumplidos.
Atributos:
Instructor.
Auto.
Horarios disponibles.
Horarios ocupados.

