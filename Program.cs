using System;
using static System.Console;

namespace TablaDeNativos_18300136
{
    class Program
    {
        static void Main(string[] args)
        {
            //En strings guardamos los nombres de las columnas de nuestras tablas
            string typeText = "Type", minimumText = "Minimum", maximumText = "Maximum";
            //En strings guardamos los nombres de las filas de nuestras tablas
            string byteText = "byte", sbyteText = "sbyte", shortText = "short", ushortText = "ushort", intText = "int", uintText = "uint", longText = "long", ulongText = "ulong", floatText = "float", doubleText = "double", decimalText = "decimal";
            //Imprimimos columnas y filas con sus respectivos valores, formateando los strings que se imprimen para darles un espacio ya establecido apareciendo de forma ordenada
            WriteLine($"{typeText, -12} {minimumText, 30} {maximumText, 30}");
            WriteLine($"{byteText, -12} {byte.MinValue, 30} {byte.MaxValue, 30}");
            WriteLine($"{sbyteText, -12} {sbyte.MinValue, 30} {sbyte.MaxValue, 30}");
            WriteLine($"{shortText, -12} {short.MinValue, 30} {short.MaxValue, 30}");
            WriteLine($"{ushortText, -12} {ushort.MinValue, 30} {ushort.MaxValue, 30}");
            WriteLine($"{intText, -12} {int.MinValue, 30} {int.MaxValue, 30}");
            WriteLine($"{uintText, -12} {uint.MinValue, 30} {uint.MaxValue, 30}");
            WriteLine($"{longText, -12} {long.MinValue, 30} {long.MaxValue, 30}");
            WriteLine($"{ulongText, -12} {ulong.MinValue, 30} {ulong.MaxValue, 30}");
            WriteLine($"{floatText, -12} {float.MinValue, 30} {float.MaxValue, 30}");
            WriteLine($"{doubleText, -12} {double.MinValue, 30} {double.MaxValue, 30}");
            WriteLine($"{decimalText, -12} {decimal.MinValue, 30} {decimal.MaxValue, 30}");
        }
    }
}
