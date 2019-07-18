Imports System
'3.1. Crear un proyecto y un módulo “Comparar” para resolver con IF: se ingresan dos valores
'numéricos e informar por pantalla cuál es la relación entre ambos: mayor, menor o igual
Module Program
    Sub Main(args As String())
        Dim valor1, valor2 As Single
        Console.WriteLine("Ingresar primer valor")
        valor1 = Console.ReadLine()
        Console.WriteLine("Ingresar segundo valor")
        valor2 = Console.ReadLine()
        If valor1 > valor2 Then
            Console.WriteLine("El valor {0} es mayor a {1}", valor1, valor2)
        ElseIf valor1 < valor2 Then
            Console.WriteLine("El valor {0} es menor a {1}", valor1, valor2)
        Else
            Console.WriteLine("Los valores {0} y {1} son iguales", valor1, valor2)
        End If
    End Sub
End Module
