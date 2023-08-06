using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using CodigoASCII.Class;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Ruta del archivo .json
        string fileName = "frases.json";
        string jsonFolderPath = "JSON"; 
        string filePath = Path.Combine(jsonFolderPath, fileName);

        string jsonPhrases = File.ReadAllText(filePath);

        // Deserializa las frases  a una lista
        List<HumanPhrase> phrases = JsonSerializer.Deserialize<List<HumanPhrase>>(jsonPhrases);

        foreach (var phrase in phrases)
        {
            string humanPhrase = TranslateCodeToHumanPhrase(phrase.Code);
            Console.WriteLine($"Código: {phrase.Code}, Frase traducida: {humanPhrase}");
        }

        Console.ReadLine(); 
    }

    public static string TranslateCodeToHumanPhrase(long code)
    {
        byte[] bytes = BitConverter.GetBytes(code);
        string result = Encoding.ASCII.GetString(bytes);
        return result;
    }

}
