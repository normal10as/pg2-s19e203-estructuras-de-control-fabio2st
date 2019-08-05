Imports System
'3.16. Crear un proyecto y un m�dulo llamado �Operaciones� que implemente una funci�n
'sobrecargada capaz de operar dos, tres y cuatro valores de acuerdo a un argumento que debe
'ser una enumeraci�n para las siguientes operaciones: suma, resta, multiplicaci�n y divisi�n.
'Tambi�n debe haber una versi�n de la funci�n que no reciba la enumeraci�n y como
'operaci�n predeterminada resuelva con una suma. Invocarla desde el m�dulo main probando
'las diferentes alternativas y mostrando los resultados por consola. Ej.
'calcular(operaciones.suma, 5, 8).Minimizar la repetici�n de c�digo.
Public Module Operaciones
    Enum Operadores
        suma
        resta
        multiplicacion
        division
    End Enum
    Sub Main(args As String())
        Dim a, b, c, d As UShort
        a = 1000
        b = 5
        c = 4
        d = 2
        Console.WriteLine("{0}+{1} = " & Calcular(Operadores.suma, a, b), a, b)
        Console.WriteLine("{0}+{1}+{2} = " & Calcular(Operadores.suma, a, b, c), a, b, c)
        Console.WriteLine("{0}+{1}+{2}+{3} = " & Calcular(Operadores.suma, a, b, c, d), a, b, c, d)
        Console.WriteLine("{0}*{1} = " & Calcular(Operadores.multiplicacion, a, b), a, b)
        Console.WriteLine("{0}*{1}*{2} = " & Calcular(Operadores.multiplicacion, a, b, c), a, b, c)
        Console.WriteLine("{0}*{1}*{2}*{3} = " & Calcular(Operadores.multiplicacion, a, b, c, d), a, b, c, d)
        Console.WriteLine("{0}-{1} = " & Calcular(Operadores.resta, a, b), a, b)
        Console.WriteLine("{0}-{1}-{2} = " & Calcular(Operadores.resta, a, b, c), a, b, c)
        Console.WriteLine("{0}-{1}-{2}-{3} = " & Calcular(Operadores.resta, a, b, c, d), a, b, c, d)
        Console.WriteLine("{0}/{1} = " & Calcular(Operadores.division, a, b), a, b)
        Console.WriteLine("{0}/{1}/{2} = " & Calcular(Operadores.division, a, b, c), a, b, c)
        Console.WriteLine("{0}/{1}/{2}/{3} = " & Calcular(Operadores.division, a, b, c, d), a, b, c, d)
        Console.WriteLine("{0}?{1} = " & Calcular(a, b), a, b)
        Console.WriteLine("{0}?{1}?{2} = " & Calcular(a, b, c), a, b, c)
        Console.WriteLine("{0}?{1}?{2}?{3} = " & Calcular(a, b, c, d), a, b, c, d)
    End Sub
    Function Calcular(operador As Operadores, valor1 As Single, valor2 As Single, valor3 As Single) As Single
        Return Calcular(operador, Calcular(operador, valor1, valor2), valor3)
    End Function
    Function Calcular(operador As Operadores, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
        Return Calcular(operador, Calcular(operador, valor1, valor2, valor3), valor4)
    End Function
    Function Calcular(valor1 As Single, valor2 As Single, valor3 As Single) As Single
        Return Calcular(Operadores.suma, valor1, Calcular(Operadores.suma, valor2, valor3))
    End Function
    Function Calcular(valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
        Return Calcular(Operadores.suma, Calcular(Operadores.suma, valor1, valor2), Calcular(Operadores.suma, valor3, valor4))
    End Function
    Function Calcular(valor1 As Single, valor2 As Single) As Single
        Return Calcular(Operadores.suma, valor1, valor2)
    End Function
    Function Calcular(operador As Operadores, valor1 As Single, valor2 As Single) As Single
        Select Case operador
            Case Operadores.suma
                Return valor1 + valor2
            Case Operadores.resta
                Return valor1 - valor2
            Case Operadores.multiplicacion
                Return valor1 * valor2
            Case Operadores.division
                Return valor1 / valor2
        End Select
    End Function
End Module