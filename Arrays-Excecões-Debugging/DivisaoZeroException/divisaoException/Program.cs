namespace divisaoException
{
  public class Program
  {
    public static void Main(string[] args)
    {
    }

    public static int DivideNumbers(int numberOne, int numberTwo)
    {
    try{

      if (numberTwo == 0)
      {
        throw new DivideByZeroException("Não pode dividir um número por zero!");
      }
      return numberOne / numberTwo;
    }
    catch(DivideByZeroException ex){

         throw ex;
      }
    }
  } 
}
