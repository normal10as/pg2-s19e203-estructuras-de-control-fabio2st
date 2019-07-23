Imports System
'3.10. Crear un proyecto y un módulo “MultiplosCinco” para resolver con For y Do Loop:
'con ingresar dos valores numéricos enteros cualquiera, el primero menor al segundo,
'calcular cuántos números múltiplos de cinco hay entre ellos e informar. 
'Repetir esta soluciónen el mismo módulo con las diferentes alternativas 
'las estructuras de repetición “do while …
'loop”, “do until … loop”, “do … loop while”, “do … loop until y “for”
Module Program
    Const valorMultiplo As UShort = 5
    Sub Main(args As String())
        Dim primero, segundo, primerMultiplo As UInteger
        primero = IngresarValor("Ingrese un valor")
        segundo = IngresarValor("Ingrese un valor mayor")
        primerMultiplo = primero + valorMultiplo - (primero Mod valorMultiplo)

        resolverConFor(primero, segundo, primerMultiplo)
        resolverConDoWhile(primero, segundo, primerMultiplo)
    End Sub

    Private Sub resolverConDoWhile(primero As UInteger, segundo As UInteger, primerMultiplo As UInteger)
        Dim cantidad As UInteger
        Dim x As UInteger = primerMultiplo
        Do While x < segundo
            cantidad += 1
            x += valorMultiplo
        Loop
        mostrarResultado("Do While", primero, segundo, cantidad)
    End Sub

    Private Sub resolverConFor(primero As UInteger, segundo As UInteger, primerMultiplo As UInteger)
        Dim cantidad As UInteger
        For x = primerMultiplo To segundo Step valorMultiplo
            cantidad += 1
        Next
        mostrarResultado("For", primero, segundo, cantidad)
    End Sub

    Private Sub mostrarResultado(mensaje As String, primero As UInteger, segundo As UInteger, cantidad As UInteger)
        Console.WriteLine("Cantidad de múltiplos de {0} entre {1} y {2} son {3} con {4}", valorMultiplo, primero, segundo, cantidad, mensaje)
    End Sub

    Private Function IngresarValor(mensaje As String) As UInteger
        Console.Write(mensaje & ": ")
        Return Console.ReadLine()
    End Function

End Module
