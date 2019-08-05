Imports System
Imports System.Math

Module Sumatoria
    Private sum, total As Integer
    Sub Main(args As String())
        Dim valor, potencia As Single
        Dim sumatoria As UInteger
        valor = IngresarValor("Ingrese N")
        For x = 1 To valor
            potencia = Pow(x, 2)
            Acumular(sumatoria, potencia)
            Console.Write("+" & potencia)
        Next
        Console.WriteLine(" = " & sumatoria)
    End Sub
    Function IngresarValor(mensaje As String)
        Dim valor As Double
        Do
            Console.Write(mensaje & " (debe ser entero positivo): ")
            valor = Console.ReadLine
        Loop Until ValidarEnteroPositivo(valor)
        Return valor
    End Function
    Function ValidarEnteroPositivo(valor As Double) As Boolean
        Return valor > 0 And valor = Truncate(valor)
    End Function
    Sub Acumular(ByRef total As UInteger, valor As UInteger)
        total += valor
    End Sub
End Module
