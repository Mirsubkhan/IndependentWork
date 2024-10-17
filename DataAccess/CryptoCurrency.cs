using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CryptoCurrency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal MarketCap { get; set; }
        public decimal Price { get; set; }
        public decimal Volume24h { get; set; }
        public decimal Change24h { get; set; }
    }
}
