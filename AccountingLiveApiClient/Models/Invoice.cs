using System;

namespace AccountingLiveApiClient.Models
{
    public sealed class Invoice
    {
        public string ID { get; set; }
        public object StaffName { get; set; }
        public string AccountName { get; set; }
        public float TaxAmount { get; set; }
        public float Total { get; set; }
        public float Balance { get; set; }
        public float Subtotal { get; set; }
        public float DiscountAmount { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string StatusCFDIName { get; set; }
        public string PaymentStatus { get; set; }
        public object CancellationTypeID { get; set; }
        public object CancellationTypeName { get; set; }
        public object ProjectName { get; set; }
        public string FormatedDate { get; set; }
        public object SatPaymentMethodName { get; set; }
        public string DocID { get; set; }
        public DateTime DocDate { get; set; }
        public string AccountID { get; set; }
        public object StaffID { get; set; }
        public float ExchangeRate { get; set; }
        public float ExchangeRate2 { get; set; }
        public string CurrencyID { get; set; }
        public string PO { get; set; }
        public string PaymentTerms { get; set; }
        public string NotesClient { get; set; }
        public float DiscountPercent { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public object ARAccountID { get; set; }
        public object ImageFilePath { get; set; }
        public object UUID { get; set; }
        public object Folio { get; set; }
        public object Serie { get; set; }
        public int StatusCFDI { get; set; }
        public string BranchID { get; set; }
        public object BranchName { get; set; }
        public object PaymentCount { get; set; }
        public object PaymentCountName { get; set; }
        public object FolioID { get; set; }
        public bool Cancelled { get; set; }
        public object SatPaymentMethodID { get; set; }
        public int InvoiceSequence { get; set; }
        public object NIF { get; set; }
        public object TaxFree { get; set; }
        public string TaxSequence { get; set; }
        public DateTime DueDate { get; set; }
        public object ProjectID { get; set; }
        public int WarehouseID { get; set; }
        public InvoiceDetail[] Items { get; set; }
        public object[] Payments { get; set; }
        public object Retentions { get; set; }
    }
}
