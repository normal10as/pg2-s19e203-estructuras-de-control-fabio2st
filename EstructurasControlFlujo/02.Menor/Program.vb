Imports System
'3.2. Crear un proyecto y un módulo “Menor” para resolver con IF: ingresar tres valores y mostrar
'el menor.
Module Program
    Sub Main(args As String())
        Dim num1, num2, num3 As Single

        Console.WriteLine("ingrese 3 numeros:")
        num1 = Console.ReadLine()
        num2 = Console.ReadLine()
        num3 = Console.ReadLine()

        If num1 < num2 And num1 < num3 Then ' se verifica el primer valor
            Console.Write("el menor es: " & num1)
        ElseIf num2 < num3 Then ' descartado el primero se verifica el segundo
            Console.Write("el menor es:" & num2)
        Else    ' descartado el primero y el segundo solo resta el tercero
            Console.Write("el menor es: " & num3)
        End If
    End Sub
End Module
