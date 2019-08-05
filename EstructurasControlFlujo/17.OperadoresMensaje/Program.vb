Imports System
Imports _16
Imports _16.Operaciones.Operaciones
'3.17. En base al ejercicio anterior: agregar una subrutina sobrecargada para mostrar por
'consola las operaciones realizadas. Esta subrutina se invoca desde el método main y ella
'invoca las funciones de cálculo. Ej.: resultado(operaciones.suma, 5, 8)
'imprimiría en consola 5 + 8 = 13.
Module OperacionesMensaje
    Sub Main(args As String())
        Dim a, b, c, d As UShort
        a = 1000
        b = 5
        c = 4
        d = 2
        Resultado(Operadores.suma, a, b)
        Resultado(Operadores.resta, a, b, c)
        Resultado(Operadores.multiplicacion, a, b, c, d)
        Resultado(Operadores.division, a, b)
    End Sub
    Sub Resultado(operador As Operadores, valor1 As Single, valor2 As Single)
        Console.Write("{1}{0}{2} = ", ObtenerSimbolo(operador), valor1, valor2)
        Console.WriteLine(Operaciones.Calcular(Operadores.suma, valor1, valor2))
    End Sub
    Sub Resultado(operador As Operadores, valor1 As Single, valor2 As Single, valor3 As Single)
        Console.Write("{1}{0}{2}{0}{3} = ", ObtenerSimbolo(operador), valor1, valor2, valor3)
        Console.WriteLine(Operaciones.Calcular(Operadores.suma, valor1, valor2, valor3))
    End Sub
    Sub Resultado(operador As Operadores, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single)
        Console.Write("{1}{0}{2}{0}{3}{0}{4} = ", ObtenerSimbolo(operador), valor1, valor2, valor3, valor4)
        Console.WriteLine(Operaciones.Calcular(Operadores.suma, valor1, valor2, valor3, valor4))
    End Sub
    Function ObtenerSimbolo(operador As Operadores) As Char
        Select Case operador
            Case Operadores.suma
                Return "+"
            Case Operadores.resta
                Return "-"
            Case Operadores.multiplicacion
                Return "*"
            Case Operadores.division
                Return "/"
        End Select
    End Function
End Module