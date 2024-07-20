namespace AgencyBankingWebAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string AcctNo { get; set; }
        public decimal Amount { get; set; }
        public decimal BookedBalance { get; set; }
        public decimal ClearedBalance { get; set; }
        public string Currency { get; set; }
        public string CustMemoLine1 { get; set; }
        public string CustMemoLine2 { get; set; }
        public string CustMemoLine3 { get; set; }
        public string EventType { get; set; }
        public string ExchangeRate { get; set; }
        public string Narration { get; set; }
        public string PaymentRef { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ValueDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionId { get; set; }
        public string TransactionType { get; set; }
    }
}
