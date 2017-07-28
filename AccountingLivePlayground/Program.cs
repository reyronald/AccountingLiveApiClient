using AccountingLiveApiClient;
using AccountingLiveApiClient.Models;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace AccountingLivePlayground
{
    class Program
    {
        static readonly string _uri = ConfigurationManager.AppSettings["AccountingLiveApiUri"];
        static readonly string _username = ConfigurationManager.AppSettings["Username"];
        static readonly string _companyID = ConfigurationManager.AppSettings["CompanyID"];
        static readonly string _password = ConfigurationManager.AppSettings["Password"];

        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            var api = new ApiClient(_uri, _username, _companyID, _password);

            Invoice[] invoiceResponse = await api.InvoicesConsumer.GetAsync();
            Item[] itemsResponse = await api.ItemsConsumer.GetAsync();
            Account[] accountsResponse = await api.AccountsConsumer.GetAsync();


            Console.ReadLine();
        }
    }
}
