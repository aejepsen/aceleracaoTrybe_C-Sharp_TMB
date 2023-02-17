public class Program {
          
    public static void Main(string[] args) {

      // Entrada de Dados
      int Age = int.Parse(Console.ReadLine());
      decimal Average = decimal.Parse(Console.ReadLine());
      bool Permission = bool.Parse(Console.ReadLine());
      string Name = Console.ReadLine();
      Console.WriteLine("Idade:" + Age);
      Console.WriteLine("Média:" + Average);
      Console.WriteLine("Permissão:" + Permission);
      Console.WriteLine("Nome:" + Name);

      // ENTRADA DE DADOS
        Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");
        Console.WriteLine("Informe o nome do còmodo: ");
        string convenient = Console.ReadLine();

        Console.WriteLine("Informe em metros a largura deste cômodo: ");
        decimal width = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Informe em metros o comprimento deste cômodo: ");
        decimal length = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada: ");
        int power = int.Parse(Console.ReadLine());

        //PROCESSAMENTO
        decimal squareMeter = width * length;
        decimal quotientX = power / 18M;
        decimal totalLightBulbs = squareMeter / quotientX;

        //SAIDA DE DADOS
        Console.WriteLine("Para iluminar o cômodo: " + convenient + " com " + squareMeter.ToString("N2") + " metros quadrados " + "será necessario a instalação de " + totalLightBulbs.ToString("N2") + " lâmpada(s)");
 }

  

  }


  


