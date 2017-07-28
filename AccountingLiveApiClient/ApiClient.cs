using AccountingLiveApiClient.Models;

namespace AccountingLiveApiClient
{
    public sealed class ApiClient
    {
        private readonly Fetch _fetch;

        private BaseConsumer<Invoice> _invoicesConsumerInstance;
        private BaseConsumer<Item> _itemsConsumerInstance;
        private BaseConsumer<Account> _accountsConsumerInstance;

        public ApiClient(string uri, string username, string companyID, string password)
        {
            _fetch = new Fetch(uri, $"{username}:{companyID}:{password}");
        }

        public BaseConsumer<Invoice> InvoicesConsumer
        {
            get
            {
                if (_invoicesConsumerInstance == null)
                {
                    _invoicesConsumerInstance = new BaseConsumer<Invoice>(_fetch, "invoices");
                }
                return _invoicesConsumerInstance;
            }
        }

        public BaseConsumer<Item> ItemsConsumer
        {
            get
            {
                if (_itemsConsumerInstance == null)
                {
                    _itemsConsumerInstance = new BaseConsumer<Item>(_fetch, "items");
                }
                return _itemsConsumerInstance;
            }
        }

        public BaseConsumer<Account> AccountsConsumer
        {
            get
            {
                if (_accountsConsumerInstance == null)
                {
                    _accountsConsumerInstance = new BaseConsumer<Account>(_fetch, "accounts");
                }
                return _accountsConsumerInstance;
            }
        }
    }
}