using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> textos = new List<string>();

        textos.Add("Este es mi correo electrónico: gomezyolamdadelcarmen. Por favor envíeme un correo.");
        textos.Add("Este es mi correo electrónico: ksegurag@miumg.edu.gt. Enviarme el documento a este correo.");
        textos.Add("Este es mi correo electrónico: seguragomezkevin2025. Enviame el correo cuando puedas.");
        textos.Add("Este es mi correo electrónico: seguragomezkevin2021. Enviame el correo con la información solicitada.");

        string patron = @"[a-zA-Z0-9._-]+@[a-zA-Z.]+\.[a-zA-Z]+";

        foreach (string t in textos)
        {
            foreach (Match correo in Regex.Matches(t, patron))
            {
                Console.WriteLine(correo.Value);
            }
        }
    }
}
