Imports System
'Crear un proyecto y un m�dulo �Angulo� para resolver con Case: ingresar el tama�o de un
'�ngulo en grados e imprimir el mensaje correspondiente seg�n la siguiente tabla:
'Agudo si es menor a 90�
'Recto si es igual a 90�
'Obtuso si es mayor que 90� pero menor que 180�
'Llano si es igual a 180�
'C�ncavo si es mayor que 180� pero menor que 360�
'Error Si el valor es menor a 0� o mayor de 360�
Module Program
    Sub Main(args As String())
        Dim ValorAngulo As Short
        Console.Write("Ingrese el valor del angulo (0� a 360�): ")
        ValorAngulo = Console.ReadLine
        Select Case ValorAngulo
            Case < 0, >= 360
                Console.WriteLine("Error")
            Case < 90
                Console.WriteLine("Es Agudo")
            Case = 90
                Console.WriteLine("Es Recto")
            Case < 180
                Console.WriteLine("Es Obtuso")
            Case = 180
                Console.WriteLine("Es Llano")
            Case Else
                Console.WriteLine("Es C�ncavo")
        End Select
    End Sub
End Module
