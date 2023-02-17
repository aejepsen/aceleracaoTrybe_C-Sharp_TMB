// See https://aka.ms/new-console-template for more information

public class Program {
    public static void Main(string[] args) {

      int qtde = 1; // 32 bits  (2^32) = -2.147.483.648 a 2.147.483.647 10 casas decimais
      uint qtde2 = 1; // 32 bits (2^32) = 0 a 4.294.967.296  10 casas decimais

      short preco3 = 1; // 16 bits (2^16) = -32.768 a 32.767 5 casas decimais
      ushort preco4 = 1; // 16 bits (2^16) = 0 a 65.536  5 casas decimais

      long preco1 = 1; // 64 bits (2^64) = -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 19 casas decimais
      ulong preco2 = 1; // 64 bits (2^64) = 0 a 18.446.744.073.709.551.616  20 casas decimais
      float peso = 1.10f; // 32 bits (2^32) = 4.294.967.296  7 casas decimais
      double preco = 1.10d; // 64 bits (2^64) = 18.446.744.073.709.551.616 15 casas decimais
      decimal valor = 0.01M; // 128 bits (2^128) = 3.402.823.669.209.384.634.633.449.612.005.806.976. 28 casas decimais

      string nome = "dotnet"; // 16 bits (2^16) = 65.536 caracteres
      char sexo = 'T'; // 1 caractere 
      bool ativo = true; // 8 bits (2^8) = 256 true ou false 

      var curso = "dotnet"; // Tipo string inferido pelo compilador
      var media = 1.10d; //  15 casas decimais Tipo double inferido pelo compilador

      Console.WriteLine(qtde);
      Console.WriteLine(qtde2);
      Console.WriteLine(preco);
      Console.WriteLine(preco1);
      Console.WriteLine(preco2);
      Console.WriteLine(preco3);
      Console.WriteLine(preco4);
      Console.WriteLine(nome);
      Console.WriteLine(peso);
      Console.WriteLine(sexo); 
      Console.WriteLine(ativo);
      Console.WriteLine(valor);
      Console.WriteLine(curso);
      Console.WriteLine(media);

      int x =10, y = 20, z = 30;

      Console.WriteLine(x);
      Console.WriteLine(y);
      Console.WriteLine(z);
      Console.WriteLine("valor de x+y+z= " + (x + y + z));
      Console.WriteLine(x + y * z);



} 

}

