Imports System
Imports System.Math
'3.18. Utilizar una función para validar los valores ingresados en el punto 2.3 sean enteros
'positivos, si no cumple esta condición pedir el reingreso del dato.
'2.3. Crear un proyecto y un m�dulo llamado �Hipotenusa� que implemente una funci�n que
'reciba el tama�o de los lados A y B, calcule y devuelva C (hipotenusa). Dados los lados A y
'B de un tri�ngulo rect�ngulo, seg�n el teorema de Pit�goras, el cuadrado de la hipotenusa
'(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la siguiente
'f�rmula: c� = a� + b�. Ingresar los valores por teclado y mostrar el resultado en consola.
Module Hipotenusa
    Sub Main(args As String())
        Dim a, b As UInteger
        a = IngresarValor("Ingrese lado 'A'")
        b = IngresarValor("Ingrese lado 'B'")
        Console.WriteLine("El lado 'C' es: " & CalcularHipotenusa(a, b))
    End Sub
    Function IngresarValor(mensaje As String) As Double
        Dim valor As Double
        Do
            Console.Write(mensaje & " (debe ser entero positivo): ")
            valor = Console.ReadLine
        Loop Until ValidarEnteroPositivo(valor)
        Return valor
    End Function
    Function ValidarEnteroPositivo(valor As Double) As Boolean
        Return valor > 0 And valor = Math.Round(valor, 0)
    End Function
    Function CalcularHipotenusa(a As UInteger, b As UInteger) As Decimal
        Return Sqrt((a ^ 2) + (b ^ 2))
    End Function
End Module


