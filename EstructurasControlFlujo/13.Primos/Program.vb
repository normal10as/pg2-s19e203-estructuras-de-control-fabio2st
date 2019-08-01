Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Un n�mero primo es un n�mero natural mayor que 1 que tiene �nicamente dos divisores distintos: �l mismo y el 1")
        Dim valor As UInteger = 2
        For x = 1 To 20
            ObtenerProximoPrimo(2)
        Next
    End Sub

    Sub ObtenerProximoPrimo(valor As UInteger)
        Dim divisor, raizcuadrada As UInteger
        ' el m�ximo valor divisor sera equivalente a la ra�z cuadrada del valor
        ' esto reduce iteraciones innecesarias
        raizcuadrada = Math.Sqrt(valor)
        Console.WriteLine("Raiz cuadrada: " & raizcuadrada)
        ' el primer valor divisor para descartar un numero primo es 2
        divisor = 2

        ' itera si el resto es distinto de cero y el divisor es menor o igual a la ra�z cuadrada
        ' si el primer calculo de resto da 0 no itera en absoluto
        Do While valor Mod divisor <> 0 And divisor <= raizcuadrada
            Console.Write(" " & divisor)
            divisor += 1
        Loop

        'si el divisor es mayor a la ra�z cuadrada es primo
        If divisor > raizcuadrada Then
            Console.WriteLine(vbCrLf & "Es primo")
        Else
            Console.WriteLine(vbCrLf & "No es primo")
        End If
    End Sub
End Module
