Imports System
'Crear un proyecto y un módulo “DiasMes” para resolver con Case: Elabore un programa
'que indique cuantos días tiene un mes respetando los siguientes requerimientos:
'• En el flujo normal se ingresa el número de mes a evaluar y mediante una enumeración
'se informa la cantidad de días que tiene el mes.
'• En el caso de ser febrero, además ingresar el año y tener en cuenta que tiene 28 días y si
'es un año bisiesto tiene 29 días. Un año bisiesto es aquél que es múltiplo de 4 y no de 100
'o cuando es múltiplo de 400. Por ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.
Module Program
    Enum Meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum
    Sub Main(args As String())
        Dim mes As Byte
        Dim anio As UShort
        Console.Write("Ingrese un mes: ")
        mes = Console.ReadLine()
        Select Case mes
            Case Meses.Febrero
                Console.Write("Indique el año: ")
                anio = Console.ReadLine()
                'If (anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0) Then
                If isMultiplo(anio, 4) And Not isMultiplo(anio, 100) Or isMultiplo(anio, 400) Then
                    Console.WriteLine("El mes tiene 29 dias")
                Else
                    Console.WriteLine("El mes tiene 28 dias")
                End If
            Case Meses.Enero, Meses.Marzo, Meses.Mayo, Meses.Julio, Meses.Agosto, Meses.Octubre, Meses.Diciembre
                Console.WriteLine("El mes tiene 31 dias")
            Case Meses.Abril, Meses.Junio, Meses.Septiembre, Meses.Noviembre
                Console.WriteLine("El mes tiene 30 dias")
            Case Else
                Console.WriteLine("mes incorrecto.")
        End Select
    End Sub

    Function isMultiplo(valor As UShort, divisor As UShort) As Boolean
        Return valor Mod divisor = 0
    End Function
End Module
