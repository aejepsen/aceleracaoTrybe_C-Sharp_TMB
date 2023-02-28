// See https://aka.ms/new-console-template for more information
public class Program {

    public static void Main(string[] args) {
        int numero = 10;
        int numero4 = 10;
        string texto = "10";
        double numeroDouble = 10.5;

        // Transformando um número inteiro em string
        string texto2 = numero.ToString();
        string texto3 = numero4.ToString();
        Console.WriteLine(texto2);
        Console.WriteLine(texto2 is string);
        Console.WriteLine(texto3);
        Console.WriteLine(texto3 is string);
        Console.WriteLine(texto2 + texto3);
        Console.WriteLine((texto2 + texto3) is string);
        Console.WriteLine("---------------");

        // Transformando um texto em número inteiro
        int numero2 = int.Parse(texto);
        Console.WriteLine(numero2);
        Console.WriteLine(numero2 is int);

        int numero3 = Convert.ToInt32(texto);
        Console.WriteLine(numero3);
        Console.WriteLine(numero3 is int);

        Console.WriteLine(numero2 + numero3);


        // Transformando um texto em número double
        // double numeroDouble2 = double.Parse(texto);
        // Console.WriteLine(numeroDouble2);

        // Transformando um número double em inteiro
        // int numero3 = (int)numeroDouble;
        // Console.WriteLine(numero3);

        // Transformando um número inteiro em double
        // double numeroDouble3 = numero;
        // Console.WriteLine(numeroDouble3);

        // Transformando um número double em string
        // string texto3 = numeroDouble.ToString();
        // Console.WriteLine(texto3);

        // Transformando um texto em número double
        // double numeroDouble4 = double.Parse(texto);
        // Console.WriteLine(numeroDouble4);

        // Transformando um texto em número inteiro
        // int numero4 = int.Parse(texto);
        // Console.WriteLine(numero4);
    }
}
