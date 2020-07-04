using NUnit.Framework;
using StockAnalyzer.Windows.Services;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StockAnalyzer.Tests
{
    public class MockStockServiceTests
    {
        [SetUp]
        public void Setup()
        {
        
        }

        [Test]
        public async Task Can_Load_All_MFST_Stocks()
        {
            var service = new MockStockService();

            var stocks = await service.GetStockPricesFor("MSFT",
                                        CancellationToken.None);

            Assert.AreEqual(stocks.Count(), 2);
            Assert.AreEqual(stocks.Sum(s => s.Change), 0.7m);
        }
    }
}