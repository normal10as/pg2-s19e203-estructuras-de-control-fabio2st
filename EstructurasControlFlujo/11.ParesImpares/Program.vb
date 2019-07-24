Imports System
'3.11. Crear un proyecto y un módulo “ParesImpares” Utilizando la estructura de repetición
'más adecuada elaborar un programa que se ingresen valores enteros hasta que se ingrese
'cero(descartar negativos).Luego informar cuantos son pares y cuantos impares. Si todos son
'pares o todos son impares informar esta situación particular en lugar de la consigna anterior.
Module Program
    Sub Main(args As String())
        Dim valor As UInteger
        Dim pares, impares As UShort
        Do
            Console.Write("Ingrese un numero positivo (0-Para Salir): ")
            valor = Console.ReadLine()
            If valor Mod 2 = 0 Then
                pares += 1
            Else
                impares += 1
            End If
        Loop While valor <> 0
        pares -= 1  ' hay que descontar el cero de salida porque es considerado par
        If pares = pares + impares Then
            Console.WriteLine("Son todos pares")
        ElseIf impares = pares + impares Then
            Console.WriteLine("Son todos impares")
        Else
            Console.WriteLine("El total de numero pares es de: " & pares)
            Console.WriteLine("El total de numeros impares es de: " & impares)
        End If
    End Sub
End Module