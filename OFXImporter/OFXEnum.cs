using System;
using System.ComponentModel;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Money.Library.Importer
{
    public enum OFXTransactionType
    {
        [Description("Basic Credit")]
        CREDIT,
        [Description("Basic Debit")]
        DEBIT,
        [Description("Interest")]
        INT,
        [Description("Dividend")]
        DIV,
        [Description("Fee")]
        FEE,
        [Description("Service Charge")]
        SRVCHG,
        [Description("Deposit")]
        DEP,
        [Description("ATM transfer")]
        ATM,
        [Description("Point of Sale transfer")]
        POS,
        [Description("Transfer")]
        XFER,
        [Description("Check")]
        CHECK,
        [Description("Payment")]
        PAYMENT,
        [Description("Cash Withdrawl")]
        CASH,
        [Description("Direct Deposit")]
        DIRECTDEP,
        [Description("Merchant Initiated Debit")]
        DIRECTDEBIT,
        [Description("Repeating Payment")]
        REPEATPMT,
        OTHER,
    }
    
    public enum AccountType
    {
        [Description("Bank Account")]
        BANK,
        [Description("Credit Card")]
        CC,
        [Description("Accounts Payable")]
        AP,
        [Description("Accounts Recievable")]
        AR,
        NA,
    }

    public enum BankAccountType
    {
        [Description("Checking Account")]
        CHECKING,
        [Description("Savings Account")]
        SAVINGS,
        [Description("Money Market Account")]
        MONEYMRKT,
        [Description("Line of Credit")]
        CREDITLINE,
        NA,
    }

    public enum TransactionCorrectionType
    {
        [Description("No correction needed")]
        NA,
        [Description("Replace this transaction with one referenced by CORRECTFITID")]
        REPLACE,
        [Description("Delete transaction")]
        DELETE,
    }

    
}
