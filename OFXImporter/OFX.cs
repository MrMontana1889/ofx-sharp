using System;
using System.Collections.Generic;
using Money.Library.Importer;

namespace OFXImporter
{
    public class OFX
    {
        public DateTime StatementStart { get; set; }

        public DateTime StatementEnd { get; set; }

        public AccountType AccType { get; set; }

        public string Currency { get; set; }

        public OFXSignOn SignOn { get; set; }

        public OFXAccount Account { get; set; }

        public OFXBalance Balance { get; set; }

        public List<OFXTransaction> Transactions { get; set; }

        public OFX()
        {
            
        }
    }
}