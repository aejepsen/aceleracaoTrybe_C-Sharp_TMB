using Moq;
using FluentAssertions;

namespace stock_options.Test;
// A função HasStock() deve verificar se a função getStock localizada em stock-options/StockOptions.cs retorna um objeto da classe Stock.

// Utilize a lib Moq para fazer os mocks da classeStock e da interface ISockService.

// Dica: você pode utilizar a interface IStock para criar o mock da classe Stock.

// A função deve receber cinco parâmetros:

// symbol: uma string indicando qual o valor do campo symbol que o mock da classe Stock deve receber.
// findStock:um double indicando qual o valor que a função getStock deve receber.
// O teste deve verificar se:

// o valor de symbol é o mesmo que o passado para a função getStock
public class TestStock
{
  [Theory]
  [InlineData("GOOG", "GOOG")]
  public void HasStock(string symbol, string findStock)
  {
      List<Stock> MockStocks(){
        var stocksListMock = new List<Stock>();
        stocksListMock.Add(new Stock("Google", symbol, "1030.00", "30", "10"));
        return stocksListMock;
      }
      var stockMock = new Mock<IStockService>();
      stockMock.Setup(x => x.stocks()).Returns(MockStocks());

      StockOptions stockOptions = new (stockMock.Object);

      if (stockOptions == null)
      {
        throw new ArgumentNullException(nameof(stockOptions));
      }else 
      {
        stockOptions.Should().NotBeNull();
      }

      var stockResult = stockOptions.getStock(symbol);

      // if(stockResult == null)
      // {
      //   throw new ArgumentNullException(nameof(stockResult));
      // }else
      // {
          stockResult.symbol.Should().Be(findStock);
      // }

  }

  [Theory]
  [InlineData("Common", "Common", 1030.00, 1000.00, 1500.00)]
  public void HasStockRecomend(string mockType, string findType, double price, double minValue, double maxValue)
  {
      List<Stock> MockStocks(){
        var stocksListMock = new List<Stock>();
        stocksListMock.Add(new Stock("Google", "GOOG", price.ToString(), "30", mockType));
        return stocksListMock;
      }
      var stockMock = new Mock<IStockService>();
      stockMock.Setup(x => x.stocks()).Returns(MockStocks());

      StockOptions stockOptions = new (stockMock.Object);

      var stockResult = stockOptions.recomendStock(mockType, minValue, maxValue);
      // if(stockResult == null){
      //   throw new ArgumentNullException(nameof(stockResult));
      // }
      stockResult.Should().NotBeNull();
      stockResult.type.Should().Be(findType);
      stockResult.lastPrice.Should().Be(price);
      //  ok
  }
}
