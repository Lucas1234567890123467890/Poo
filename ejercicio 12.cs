Clase
12

MODULO 1 — POO Basica
Listas de Objetos y LINQ Basico

Objetivo
• Manejar colecciones de objetos con
List&lt; T & gt; aplicando metodos de
busqueda, filtrado y ordenamiento con
LINQ.

Contenido
• List&lt; T & gt;: coleccion tipada y dinamica de
objetos
• Add, Remove, Find, FindAll, Contains,
Count
• foreach sobre lista de objetos propios
• LINQ basico: Where, Select, OrderBy,
First, Any
• Convertir resultados con ToList() y
Average()

Codigo de ejemplo
List&lt; Alumno & gt; alumnos = new();
alumnos.Add(new Alumno(&quot; Ana & quot;, 9));
alumnos.Add(new Alumno(&quot; Luis & quot;, 6));
alumnos.Add(new Alumno(&quot; Mia & quot;, 8));
alumnos.Add(new Alumno(&quot; Juan & quot;, 5));
// Filtrar con LINQ
var aprobados = alumnos.Where(a = &gt; a.Nota & gt;= 7).ToList();
// Ordenar
var ordenados = alumnos.OrderByDescending(a = &gt; a.Nota).ToList();
// Calcular
double promedio = alumnos.Average(a = &gt; a.Nota);
// Buscar uno
Alumno? mejor = alumnos.FirstOrDefault(
a = &gt; a.Nota == alumnos.Max(x = &gt; x.Nota));
// Verificar condicion
bool hayAprobados = alumnos.Any(a = &gt; a.Nota & gt;= 7);

EJERCICIOS
111. Crear lista de Productos con Nombre y Precio.
112. Imprimir todos los productos con foreach.
113. Filtrar productos con precio mayor a 1000.
114. Ordenar productos por precio descendente.
115. Buscar producto por nombre con Find.
116. Calcular precio promedio con Average.
117. Contar cuantos productos hay con precio &gt; 500.

118.Eliminar un producto de la lista con Remove.
119. Verificar si existe algun producto con precio &gt; 10000.
120.Usar Select para crear lista solo de nombres (List&lt; string&gt;).