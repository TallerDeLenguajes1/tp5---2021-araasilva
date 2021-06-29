El tipo de dato string es de tipo referencia pero funciona como si fuera tipo valor.
Secuencia de escape	Nombre de carácter			
\'			Comilla simple					
\"			Comilla doble					
\\			Barra diagonal inversa				
\0			Null						
\a			Alerta						
\b			Retroceso					
\f			Avance de página				
\n			Nueva línea					
\r			Retorno de carro				
\t			Tabulación horizontal				
\v			Tabulación vertical				
\u			Secuencia de escape Unicode(UTF-16)		
\U			Secuencia de escape Unicode (UTF-32)		
\x			Secuencia de escape Unicode similar a "\u" excepto con longitud variable.

Cuando se pone @ antes de una cadena marca la cadena como literal de cadena literal : se ignora cualquier elemento de la cadena que normalmente se interpretaría como una secuencia de escape .
Hay una excepción: se necesita una secuencia de escape para las comillas dobles. Para escapar de una comilla doble, debe poner dos comillas dobles seguidas. Por ejemplo, @""""evalúa a ".