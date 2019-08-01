Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Un número primo es un número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1")
        Dim valor As UInteger = 2
        For x = 1 To 20
            ObtenerProximoPrimo(valor)
            Console.Write(" " & valor)
        Next
    End Sub
    Sub ObtenerProximoPrimo(ByRef valor As UInteger)
        Do
            valor += 1
        Loop Until isPrimo(valor)
    End Sub
    Function isPrimo(valor As UInteger) As Boolean
        Dim divisor, raizcuadrada As UInteger
        ' el máximo valor divisor sera equivalente a la raíz cuadrada del valor
        ' esto reduce iteraciones innecesarias
        raizcuadrada = Math.Sqrt(valor)
        'Console.WriteLine("Raiz cuadrada: " & raizcuadrada)
        ' el primer valor divisor para descartar un numero primo es 2
        divisor = 2
        ' itera si el resto es distinto de cero y el divisor es menor o igual a la raíz cuadrada
        ' si el primer calculo de resto da 0 no itera en absoluto
        Do While valor Mod divisor <> 0 And divisor <= raizcuadrada
            'Console.Write(" " & divisor)
            divisor += 1
        Loop
        'si el divisor es mayor a la raíz cuadrada es primo
        Return divisor > raizcuadrada
    End Function
End Module
