// Escriba un programa que cuente el número de ocurrencias de cada letra en una palabra leída
// como entrada. Por ejemplo, “Mortimer” contiene dos “ m ”, una “ o ”, dos “ r ”, una “ i ”, una “ t ” y
// una “ e ”.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContadorOcurrenciasEnPalabras
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Pedir al usuario que ingrese una palabra
      Console.Write("Ingrese una palabra: ");
      string palabra = Console.ReadLine();

      // Crear un diccionario para almacenar el número de ocurrencias de cada letra
      Dictionary<char, int> ocurrencias = new Dictionary<char, int>();

      // Iterar sobre cada letra en la palabra y contar sus ocurrencias
      foreach (char letra in palabra)
      {
        if (ocurrencias.ContainsKey(letra))
        {
          ocurrencias[letra]++;
        }
        else
        {
          ocurrencias[letra] = 1;
        }
      }
      // Mostrar el número de ocurrencias de cada letra
      Console.WriteLine("Número de ocurrencias de cada letra en la palabra:");
      foreach (KeyValuePair<char, int> par in ocurrencias)
      {
        Console.WriteLine(par.Key + ": " + par.Value);
      }
    }
  }
}