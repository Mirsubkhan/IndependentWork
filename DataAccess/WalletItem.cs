using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WalletItem
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public Guid CryptoAssetId { get; set; }
        
    }
}
