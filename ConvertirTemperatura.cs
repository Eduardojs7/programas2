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

public class Program
{
    public static void Main()
    {
        // Solicitar al usuario la temperatura en Celsius
        Console.Write("Introduce la temperatura en Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convertir a Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Mostrar el resultado utilizando concatenación
        Console.WriteLine(celsius + "°C es igual a " + fahrenheit + "°F");
    }
}
