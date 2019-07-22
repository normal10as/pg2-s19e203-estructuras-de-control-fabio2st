Imports System
'3.9. Crear un proyecto y un módulo “ConversionMedidas”, para resolver con CASE: Elabore un
'algoritmo que permita hacer conversiones de equivalencias entre metros, centímetros,
'yardas, pies y pulgadas: 
'• Presentar un menú y preguntar que unidad de medida desea convertir (pie, pulgadas,
'yarda, pulgada, cms y metros), el valor a convertir y después mostrar las equivalencias.
'• Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
'pulgada = 2.54 cm, 1 metro = 100 cm.
'• Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.

Module ConversionMedidas
    Enum UnidadesMedida
        Pie = 1
        Pulgada
        Yarda
        Centimetro
        Metro
    End Enum
    Sub Main(args As String())
        Dim valor As Single
        Dim unidadMedida As UnidadesMedida
        unidadMedida = ingresarUnidadMedida()
        Console.Write("Ingrese el valor a convertir: ")
        valor = Console.ReadLine()
        Console.WriteLine("{0} {1}s Equivalen a:", valor, unidadMedida)
        convertirDown(unidadMedida, valor)
        convertirUp(unidadMedida, valor)
    End Sub
    Function ingresarUnidadMedida() As UnidadesMedida
        Dim eleccion As UnidadesMedida
        Console.WriteLine("Seleccione la unidad de medida a convertir")
        Console.WriteLine("{0} - {1}", UnidadesMedida.Pie.GetHashCode, UnidadesMedida.Pie.ToString())
        Console.WriteLine("{0} - {1}", UnidadesMedida.Pulgada.GetHashCode, UnidadesMedida.Pulgada.ToString())
        Console.WriteLine("{0} - {1}", UnidadesMedida.Yarda.GetHashCode, UnidadesMedida.Yarda.ToString())
        Console.WriteLine("{0} - {1}", UnidadesMedida.Centimetro.GetHashCode, UnidadesMedida.Centimetro.ToString())
        Console.WriteLine("{0} - {1}", UnidadesMedida.Metro.GetHashCode, UnidadesMedida.Metro.ToString())
        eleccion = Console.ReadLine()
        Return eleccion
    End Function
    Const pieYarda As UShort = 3
    Function yardaToPie(valor As Single) As Single
        Return valor * pieYarda
    End Function
    Function pieToYarda(valor As Single) As Single
        Return valor / pieYarda
    End Function
    Const pulgadaPie As UShort = 12
    Function pieToPulgada(valor As Single) As Single
        Return valor * pulgadaPie
    End Function
    Function pulgadaToPie(valor As Single) As Single
        Return valor / pulgadaPie
    End Function
    Const centimetroPulgada As Decimal = 2.54
    Function pulgadaToCentimetro(valor As Single) As Single
        Return valor * centimetroPulgada
    End Function
    Function centimetroToPulgada(valor As Single) As Single
        Return valor / centimetroPulgada
    End Function
    Const centimetroMetro As UShort = 100
    Function centimetroToMetro(valor As Single) As Single
        Return valor / centimetroMetro
    End Function
    Function MetroTocentimetro(valor As Single) As Single
        Return valor * centimetroMetro
    End Function

    Sub convertirDown(origen As UnidadesMedida, valor As Single)
        Dim resultado As Single
        Dim proximaUnidadMedida As UnidadesMedida
        Select Case origen
            Case UnidadesMedida.Yarda
                resultado = yardaToPie(valor)
                proximaUnidadMedida = UnidadesMedida.Pie
            Case UnidadesMedida.Pie
                resultado = pieToPulgada(valor)
                proximaUnidadMedida = UnidadesMedida.Pulgada
            Case UnidadesMedida.Pulgada
                resultado = pulgadaToCentimetro(valor)
                proximaUnidadMedida = UnidadesMedida.Centimetro
            Case UnidadesMedida.Centimetro
                resultado = centimetroToMetro(valor)
                proximaUnidadMedida = UnidadesMedida.Metro
            Case UnidadesMedida.Metro
                Return
        End Select
        Console.WriteLine("{0} {1}", resultado, proximaUnidadMedida)
        convertirDown(proximaUnidadMedida, resultado)
    End Sub
    Sub convertirUp(origen As UnidadesMedida, valor As Single)
        Dim resultado As Single
        Dim proximaUnidadMedida As UnidadesMedida
        Select Case origen
            Case UnidadesMedida.Metro
                resultado = MetroTocentimetro(valor)
                proximaUnidadMedida = UnidadesMedida.Centimetro
            Case UnidadesMedida.Centimetro
                resultado = centimetroToPulgada(valor)
                proximaUnidadMedida = UnidadesMedida.Pulgada
            Case UnidadesMedida.Pulgada
                resultado = pulgadaToPie(valor)
                proximaUnidadMedida = UnidadesMedida.Pie
            Case UnidadesMedida.Pie
                resultado = pieToYarda(valor)
                proximaUnidadMedida = UnidadesMedida.Yarda
            Case UnidadesMedida.Yarda
                Return
        End Select
        Console.WriteLine("{0} {1}", resultado, proximaUnidadMedida)
        convertirUp(proximaUnidadMedida, resultado)
    End Sub
End Module