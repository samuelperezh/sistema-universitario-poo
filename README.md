# SistemaUniversitario
Se quiere diseñar un sistema universitario exclusivo para los estudiantes de Ingeniería en Ciencia de Datos en el periodo 2022-2.  El sistema debe permitir el ingreso de estudiantes, profesores y administrativos, cada uno puede realizar diferentes funciones dentro del sistema:

Los estudiantes pueden inscribir materias y cancelarlas, pueden revisar sus calificaciones y pueden ver qué materias matricularon con su respectivo docente. Los profesores pueden subir las calificaciones de sus estudiantes y pueden ver las materias que dictan. Por último, los administrativos tienen la posibilidad de crear, eliminar y mostrar estudiantes.

Al crear un nuevo estudiante, el sistema debe generar un código aleatorio, el cual será su identificación dentro de la universidad. Los profesores deberán especificar el porcentaje y una descripción de la calificación asignada a cada estudiante. Cada materia del pensum debe contener un número de créditos, un código único y un profesor asignado.

Existen 3 tipos de estudiantes: becados, regulares y de intercambio.

Los estudiantes **becados** pueden inscribir un máximo de 17 créditos, teniendo en cuenta que cada crédito tiene un valor de $574.000. La beca significa que se les da un descuento del 80% sobre el total de la matrícula. Para conservar la beca, la calificación final del semestre debe ser mayor o igual a 4, si el estudiante no cumple con este requisito, pasa a ser estudiante regular el próximo semestre. Por otro lado, el estudiante aprueba el semestre con una calificación mayor o igual a 3.

Los estudiantes **regulares** también pueden inscribir un máximo de 17 créditos, teniendo en cuenta que cada crédito tiene un valor de $574.000. El estudiante aprueba el semestre con una calificación final mayor o igual a 3 y no se le da ningún descuento sobre la matrícula.

Los estudiantes de **intercambio** pueden inscribir un máximo de 12 créditos, teniendo en cuenta que cada crédito tiene un valor de $800.000. Los estudiantes aprueban con una calificación final mayor o igual a 3,5 y no se le da ningún descuento sobre la matrícula.

La calificación final del semestre de cada estudiante se calcula con base al número de créditos de cada materia y su calificación final. Esto quiere decir que es una media ponderada.

Al final del semestre, se debe generar un reporte descargable que incluya el nombre de los estudiantes, su tipo, su promedio y el número de créditos inscritos.
