Imports System

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
