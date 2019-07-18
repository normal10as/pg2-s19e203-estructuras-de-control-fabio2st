Imports System
'Crear un proyecto y un módulo “Venta” para resolver con If: ingresar dos valores
'relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es entre a 10 y
'50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es del 10% y si
'es 251 o más el descuento es del 20%. Informar subtotal (cantidad por precio unitario),
'porcentaje de descuento aplicado, monto descontado y el total (subtotal – monto
'descontado).
Module Program
    Sub Main(args As String())
        Dim cantidad As Int16
        Dim precioUnitario, descuento, total As Decimal

        Console.Write("Ingrese el precio del articulo: ")
        precioUnitario = Console.ReadLine()
        Console.Write("Ingrese la cantidad del articulo: ")
        cantidad = Console.ReadLine()
        If cantidad > 250 Then
            descuento = 0.2
        ElseIf cantidad > 50 Then
            descuento = 0.1
        ElseIf cantidad > 10 Then
            descuento = 0.05
        End If
        total = cantidad * precioUnitario
        Console.WriteLine("el sub total es: " & total)
        Console.WriteLine("el descuento es {0}%: {1}", descuento * 100, total * descuento)
        total -= total * descuento
        Console.WriteLine("el total es: " & total)
    End Sub
End Module
