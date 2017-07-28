namespace AccountingLiveApiClient.Models
{
    public sealed class Account
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public object Phone { get; set; }
        public object Fax { get; set; }
        public string EMail { get; set; }
        public object CompanyClassID { get; set; }
        public string CurrencyID { get; set; }
        public object Notes { get; set; }
        public bool TaxFree { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsVendor { get; set; }
        public string TaxPayerID { get; set; }
        public object BillingAddress { get; set; }
        public object BillingAddress2 { get; set; }
        public object BillingCity { get; set; }
        public object BillingState { get; set; }
        public object BillingZipCode { get; set; }
        public object BillingCountryID { get; set; }
        public object BillingCountryName { get; set; }
        public object ShippingAddress { get; set; }
        public object ShippingAddress2 { get; set; }
        public object ShippingCity { get; set; }
        public object ShippingState { get; set; }
        public object ShippingZipCode { get; set; }
        public object ShippingCountryID { get; set; }
        public object ShippingCountryName { get; set; }
        public int InvoiceSequence { get; set; }
        public int TaxVoucherSequence { get; set; }
        public bool DontUpdateContacts { get; set; }
        public object ARAccountID { get; set; }
        public object APAccountID { get; set; }
        public bool Inactive { get; set; }
        public object Mobile { get; set; }
        public object Skype { get; set; }
        public int PriceLevel { get; set; }
        public object[] contacts { get; set; }
    }
}
