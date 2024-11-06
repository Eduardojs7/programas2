/*
 * Title: Convertidor de temperatura de Celsius a Fahrenheit
 * Filename: ConvertirTemperatura.cs
 * Autor: Sanchez Salinas Eduardo Josue
 * Date: 2024-10-02
 * Description: Programa que convierte una temperatura en grados Celsius a Fahrenheit.
 * Input: Temperatura en grados Celsius desde la consola.
 * Output: Temperatura en grados Fahrenheit en la consola.
 */

using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario la temperatura en Celsius
        Console.WriteLine("Ingrese la temperatura en grados Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convertir Celsius a Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Mostrar el resultado en Fahrenheit
        Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit}°F");
    }
}

