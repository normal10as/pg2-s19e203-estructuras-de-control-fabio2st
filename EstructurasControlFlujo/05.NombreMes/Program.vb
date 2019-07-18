Imports System
'3.5. Crear un proyecto y un módulo “NombreMes” para resolver con CASE. Crear una
'enumeración para los meses del año. Ingresar un valor numérico y mostrar a que mes
'corresponde.Si el valor es inválido mostrar el mensaje correspondiente.
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
        Dim MesIngresado As Byte
        Console.Write("Ingrese un numero de mes: ")
        MesIngresado = Console.ReadLine
        Select Case MesIngresado
            Case Meses.Enero
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Enero)
            Case Meses.Febrero
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Febrero)
            Case Meses.Marzo
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Marzo)
            Case Meses.Abril
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Abril)
            Case Meses.Mayo
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Mayo)
            Case Meses.Junio
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Junio)
            Case Meses.Julio
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Julio)
            Case Meses.Agosto
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Agosto)
            Case Meses.Septiembre
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Septiembre)
            Case Meses.Octubre
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Octubre)
            Case Meses.Noviembre
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Noviembre)
            Case Meses.Diciembre
                Console.WriteLine("EL numero de mes ingresado es: {0} y corresponde al mes de {1} ", MesIngresado, Meses.Diciembre)
            Case Else
                Console.WriteLine("El numero de mes ingresado es incorrecto")
        End Select
    End Sub
End Module
