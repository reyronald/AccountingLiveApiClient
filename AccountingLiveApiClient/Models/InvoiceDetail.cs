namespace AccountingLiveApiClient.Models
{
    public sealed class InvoiceDetail
    {
        public string ID { get; set; }
        public object ItemID { get; set; }
        public object ItemSKU { get; set; }
        public string ItemName { get; set; }
        public float Price { get; set; }
        public float Cost { get; set; }
        public float Quantity { get; set; }
        public object TaxID { get; set; }
        public object TaxName { get; set; }
        public float TaxPercent { get; set; }
        public object SalesAccountID { get; set; }
        public string ExtraDescription1 { get; set; }
        public string ExtraDescription2 { get; set; }
        public string ExtraDescription3 { get; set; }
        public string ExtraDescription4 { get; set; }
        public string ExtraDescription5 { get; set; }
        public string ExtraDescription6 { get; set; }
        public string ExtraDescription7 { get; set; }
        public string ExtraDescription8 { get; set; }
        public string ExtraDescription9 { get; set; }
        public float DiscountPercent { get; set; }
    }
}
