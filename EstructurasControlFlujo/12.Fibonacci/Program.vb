Imports System

Module Program
    Sub Main(args As String())
        Dim semilla1, semilla2, nuevoValor As UShort
        ' los dos primeros valores son asignados por definición
        semilla2 = 1
        mostrar(1, semilla1)
        mostrar(2, semilla2)
        ' los siguientes valores son calculados
        For x = 3 To 20
            nuevoValor = semilla1 + semilla2
            mostrar(x, nuevoValor)
            semilla1 = semilla2
            semilla2 = nuevoValor
        Next
    End Sub
    Private Sub mostrar(indice As UShort, valor As UShort)
        Console.WriteLine("{0}) {1}", indice, valor)
    End Sub
End Module
