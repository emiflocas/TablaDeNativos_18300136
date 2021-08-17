using System;
using static System.Console;

namespace TablaDeNativos_18300136
{
    class Program
    {
        static void printLine()// Imprimimos n "-" para formar el margen de nuestra tabla
        {
            for(int a = 0; a < 94; a++)
            {
                Write("-");
            }
            WriteLine();
        }
        
        static void Main(string[] args)
        {
            //En strings guardamos los nombres de las columnas de nuestras tablas
            string typeText = "Type", bytesOfMemoryText = "Byte(s) of memory",  minimumText = "Minimum", maximumText = "Maximum";
            //En strings guardamos los nombres de las filas de nuestras tablas
            string byteText = "byte", sbyteText = "sbyte", shortText = "short", ushortText = "ushort", intText = "int", uintText = "uint", longText = "long", ulongText = "ulong", floatText = "float", doubleText = "double", decimalText = "decimal";
            //Imprimimos columnas y filas con sus respectivos valores, formateando los strings que se imprimen para darles un espacio ya establecido apareciendo de forma ordenada.
            #region PrintTable
            printLine();
            WriteLine($"{typeText, -12} {bytesOfMemoryText, -19} {minimumText, 30} {maximumText, 30}");
            printLine();
            WriteLine($"{byteText, -12} {sizeof(byte), -19} {byte.MinValue, 30} {byte.MaxValue, 30}");
            WriteLine($"{sbyteText, -12} {sizeof(sbyte), -19} {sbyte.MinValue, 30} {sbyte.MaxValue, 30}");
            WriteLine($"{shortText, -12} {sizeof(short), -19} {short.MinValue, 30} {short.MaxValue, 30}");
            WriteLine($"{ushortText, -12} {sizeof(ushort), -19} {ushort.MinValue, 30} {ushort.MaxValue, 30}");
            WriteLine($"{intText, -12} {sizeof(int), -19} {int.MinValue, 30} {int.MaxValue, 30}");
            WriteLine($"{uintText, -12} {sizeof(uint), -19} {uint.MinValue, 30} {uint.MaxValue, 30}");
            WriteLine($"{longText, -12} {sizeof(long), -19} {long.MinValue, 30} {long.MaxValue, 30}");
            WriteLine($"{ulongText, -12} {sizeof(ulong), -19} {ulong.MinValue, 30} {ulong.MaxValue, 30}");
            WriteLine($"{floatText, -12} {sizeof(float), -19} {float.MinValue, 30} {float.MaxValue, 30}");
            WriteLine($"{doubleText, -12} {sizeof(double), -19} {double.MinValue, 30} {double.MaxValue, 30}");
            WriteLine($"{decimalText, -12} {sizeof(decimal), -19} {decimal.MinValue, 30} {decimal.MaxValue, 30}");
            printLine();
            #endregion
        }
    }
}
