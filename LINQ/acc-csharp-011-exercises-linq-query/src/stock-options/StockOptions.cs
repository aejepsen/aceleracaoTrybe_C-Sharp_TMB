namespace stock_options;
//  ok
using System.Linq;
public class StockOptions
{
  private IStockService stockOptions;
  public StockOptions(IStockService stocks)
  {
    this.stockOptions = stocks;

  }

  /// <summary>
  /// This function find the best stock option for the given stock
  /// </summary>
  /// <param name="symbol"> A string to be find</param>
  /// <returns>A stock</returns>
  public IStock? getStock(string symbol)
  {
    return stockOptions.stocks().Where(stock => stock.symbol == symbol).FirstOrDefault();
  }

  /// <summary>
  /// This function find the best stock option for the price range given
  /// </summary>
  /// <param name="type"> A string to be find</param>
  /// <param name="minPrice"> A double to be find</param>
  /// /// <param name="maxPrice"> A double to be find</param>
  /// <returns>A stock</returns>

  public IStock? recomendStock(string type, double minPrice, double maxPrice)
  {
    return stockOptions.stocks().Where(stock => stock.type == type && stock.lastPrice >= minPrice && stock.lastPrice <= maxPrice).FirstOrDefault();
  }
}
