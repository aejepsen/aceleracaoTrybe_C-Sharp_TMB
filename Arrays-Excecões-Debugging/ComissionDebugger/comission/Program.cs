using System;

namespace comission
{
  public class Comission
  {
    public static void Main(string[] args)
    {
    }
  
    public decimal Calculate(decimal orderPrice)
    {
      try{
        if(orderPrice < 0)
        {
          throw new Exception("Order price cannot be negative");
        }
        return orderPrice * 10/100;
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
        throw;
      }
      finally
      {
        Console.WriteLine("Finally block");
      }
    }

  }
}
