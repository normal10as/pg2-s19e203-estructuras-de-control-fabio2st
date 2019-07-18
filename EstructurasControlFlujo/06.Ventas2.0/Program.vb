Imports System
'3.6. Crear un proyecto y un módulo “Venta2.0”, para resolver el problema “Venta” (3.4) con
'Case
Module Program
    Sub Main(args As String())
        Dim cantidad As Int16
        Dim precioUnitario, descuento, total As Decimal
        Console.Write("Cantidad del Producto: ")
        cantidad = Console.ReadLine()
        Console.Write("Precio Unitario: ")
        precioUnitario = Console.ReadLine()
        Select Case cantidad
            Case 10 To 50
                descuento = 0.05
            Case 51 To 250
                descuento = 0.1
            Case Is > 250
                descuento = 0.2
        End Select
        total = cantidad * precioUnitario
        Console.WriteLine("el sub total es: " & total)
        Console.WriteLine("el descuento es {0}%: {1}", descuento * 100, total * descuento)
        total -= total * descuento
        Console.WriteLine("el total es: " & total)
    End Sub
End Module
