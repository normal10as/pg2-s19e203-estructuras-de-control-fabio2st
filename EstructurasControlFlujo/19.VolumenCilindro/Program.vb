Imports System
'3.19. Utilizar un procedimiento para validar los valores ingresados en el punto 2.4 sean
'positivos, si no cumple esta condición pedir el reingreso del dato.
'2.4. Crear un proyecto y un módulo llamado “VolumenCilindro” que implemente una función
'que lea el radio de la base y la altura de un cilindro y que calcule y devuelva el volumen. El
'volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el
'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v =
'πr²h. Ingresar los valores por teclado y mostrar el resultado en consola
Module VolumenCilindro
    Sub Main(args As String())
        Dim base, altura As Double
        base = IngresarValor("Ingrese la base del cilindro")
        altura = IngresarValor("Ingrese la altura del cilindro")
        Console.WriteLine("El volumen del cilindro es: " & CalcularCilindro(base, altura))
    End Sub
    Function IngresarValor(mensaje As String) As Double
        Dim valor As Double
        Do
            Console.Write(mensaje & " (debe ser positivo): ")
            valor = Console.ReadLine()
        Loop Until ValidarPositivo(valor)
        Return valor
    End Function
    Function ValidarPositivo(valor As Double) As Boolean
        Return valor > 0
    End Function
    Function CalcularCilindro(base As Double, altura As Double) As Double
        Return Math.PI * base * base * altura
    End Function
End Module
