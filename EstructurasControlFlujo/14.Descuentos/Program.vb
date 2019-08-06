Imports System
Module Program
    Sub Main(args As String())
        Dim cantidad As Int16
        Dim precio, descuento, subtotal, montoDescontado, totalArticulo, totalDescuento, total As Decimal
        cantidad = LeerCantidad()
        Do While cantidad > 0
            precio = LeerPrecio()
            subtotal = cantidad * precio
            Console.WriteLine("Subtotal: " & subtotal)
            descuento = ObtenerDescuento(cantidad)
            montoDescontado = subtotal * descuento / 100
            Console.WriteLine($"Descuento {descuento}%: $-{montoDescontado}")
            totalArticulo = subtotal - montoDescontado
            Console.WriteLine("Total: " & totalArticulo)
            totalDescuento += montoDescontado
            total += totalArticulo
            cantidad = LeerCantidad()
        Loop
        Console.WriteLine("Sumatoria descuentos: " & totalDescuento)
        Console.WriteLine("Total general: " & total)
    End Sub
    Private Function ObtenerDescuento(cantidad As Short) As Decimal
        Select Case cantidad
            Case 10 To 50
                Return 5
            Case 51 To 250
                Return 10
            Case >= 251
                Return 20
            Case Else
                Return 0
        End Select
    End Function
    Private Function LeerCantidad() As Short
        Dim cantidad As Short
        Console.Write(vbCrLf & "Cantidad : ")
        cantidad = Console.ReadLine()
        Return cantidad
    End Function
    Private Function LeerPrecio() As Decimal
        Dim monto As Decimal
        Console.Write("Precio: ")
        monto = Console.ReadLine()
        Return monto
    End Function
End Module