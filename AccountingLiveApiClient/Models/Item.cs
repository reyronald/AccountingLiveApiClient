namespace AccountingLiveApiClient.Models
{
    public sealed class Item
    {
        public string ID { get; set; }
        public string TaxName { get; set; }
        public float TaxPercent { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float? Stock { get; set; }
        public object TaxID { get; set; }
        public object UOM { get; set; }
        public float Cost { get; set; }
        public object Notes { get; set; }
        public bool TrackInventory { get; set; }
        public bool Billable { get; set; }
        public object IncomeAccountID { get; set; }
        public object DiscountAccountID { get; set; }
        public object ReturnsAccountID { get; set; }
        public object PurchaseAccountID { get; set; }
        public object IncomeAccountName { get; set; }
        public object DiscountAccountName { get; set; }
        public object ReturnsAccountName { get; set; }
        public object PurchaseAccountName { get; set; }
    }
}
