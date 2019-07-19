Imports System
'Crear un proyecto y un módulo “Angulo” para resolver con Case: ingresar el tamaño de un
'ángulo en grados e imprimir el mensaje correspondiente según la siguiente tabla:
'Agudo si es menor a 90°
'Recto si es igual a 90°
'Obtuso si es mayor que 90° pero menor que 180°
'Llano si es igual a 180°
'Cóncavo si es mayor que 180° pero menor que 360°
'Error Si el valor es menor a 0º o mayor de 360º
Module Program
    Sub Main(args As String())
        Dim ValorAngulo As Short
        Console.Write("Ingrese el valor del angulo (0° a 360°): ")
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
                Console.WriteLine("Es Cóncavo")
        End Select
    End Sub
End Module
