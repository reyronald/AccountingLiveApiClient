namespace AccountingLiveApiClient.Models
{
    public sealed class ApiResponse<T> where T : class
    {
        public Status status { get; set; }
        public T data { get; set; }
    }
}
