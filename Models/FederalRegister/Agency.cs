namespace Gtc.Models.FederalRegister 
{

    public class Agency {
        public string RawName { get; set; }
        public string Name { get; set; }
        public int Id;
        public string Url { get; set; }
        public string JsonUrl { get; set; }
        public int? ParentId { get; set; }
        public string Slug { get; set; }
        
        public Agency(string rawName, string name, int id, string url, string jsonUrl, int? parentId, string slug)
        {
            RawName = rawName;
            Name = name;
            Id = id;
            Url = url;
            JsonUrl = jsonUrl;
            ParentId = parentId;
            Slug = slug;
        }

        public override string ToString() 
        {
            return $"#{nameof(Agency)}\n {nameof(RawName)}: {RawName}\n {nameof(Name)}: {Name}\n  {nameof(Id)}: {Id}\n {nameof(Url)}: {Url}\n {nameof(JsonUrl)}: {JsonUrl}\n {nameof(ParentId)}: {ParentId}\n {nameof(Slug)}: {Slug}\n";
        }
    }
}