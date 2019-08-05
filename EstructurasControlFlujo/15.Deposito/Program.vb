Imports System
'3.15. Crear un proyecto y un módulo “Deposito” para resolver el siguiente planteo: se
'deposita un capital a un plazo de n meses, con una tasa de interés de 36% anual (es una
'constante), capitalizable cada mes, es decir, se suman los intereses ganados al capital.
'Elaborar un algoritmo que ingrese el capital inicial, la cantidad de meses y luego imprima el
'siguiente reporte:
'MES CAPITAL INTERES SALDO
'1 99,999.99 99,999.99 99,999.99
'2 99,999.99 99,999.99 99,999.99
'x xx, xxx.xx xx,xxx.xx xx,xxx.xx
'n 99, 999.99 99, 999.99 99, 999.99
'TOTAL INTERES GANADO: 99,999.99
'Donde:
'MES: es el número de mes.
'CAPITAL: en el primer mes es el capital inicial y en los meses siguientes es el saldo
'acumulado anterior. Por ejemplo, en el mes 1, el capital es el ingresado, para el mes 2,
'deberá tener incrementado el interés que ganó en el mes 1, y así sucesivamente.
'INTERES: es el capital por la tasa mensual de interés (tasa anual / 12), osea es el valor
'que gana en el mes correspondiente.
'SALDO: es el el capital sumado el interés.
'TOTAL INTERES GANADO: es la sumatoria de los intereses mensuales.
Module Program
    Const interesAnual As UShort = 36
    Sub Main(args As String())
        Dim capital, montoInteresMensual, sumatoriaInteres, capital_inicial, saldo As Single
        Dim cantidadMeses As UShort
        Console.Write("Capital a depositar: ")
        capital_inicial = Console.ReadLine()
        capital = capital_inicial
        Console.Write("Meses a depositar: ")
        cantidadMeses = Console.ReadLine()
        Console.WriteLine("Mes | Capital       | Interes      | Saldo")
        For mes As Int16 = 1 To cantidadMeses
            montoInteresMensual = interesAnual / 12 / 100 * capital
            saldo = capital + montoInteresMensual
            Console.WriteLine($" {mes,2} |  {capital,12:c} | {montoInteresMensual,12:c} | {saldo,12:c}")
            capital = saldo
            sumatoriaInteres += montoInteresMensual
        Next
        Console.WriteLine("Total Interes ganado: {0,12:c}", sumatoriaInteres)
    End Sub
End Module
