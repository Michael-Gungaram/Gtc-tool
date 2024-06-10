using Gtc.Models.FederalRegister;

namespace GtcTool.Models.FederalRegister
{
    public class Response
    {
        public int Count { get; set; }
        public string Description { get; set; }
        public int TotalPages { get; set; }
        public string NextPageUrl { get; set; }
        public List<Document> Results { get; set; }

        public Response(int count, string description, int totalPages, string nextPageUrl)
        {
            Count = count;
            Description = description;
            TotalPages = totalPages;
            NextPageUrl = nextPageUrl;
            Results = new List<Document>();
        }

        public override string ToString()  
        {
            return $"#{nameof(Response)}\n {nameof(Count)}: {Count}\n {nameof(Description)}: {Description}\n {nameof(TotalPages)}: {TotalPages}\n {nameof(NextPageUrl)}: {NextPageUrl}\n";
        }
    }
}