using System.Collections;

namespace Gtc.Models.FederalRegister 
{
    public class Document {
        public string Type { get; set; }
        public string Abstract { get; set; }
        public string Title { get; set; }
        public string DocumentNumber { get; set; }
        public string HtmlUrl { get; set; }
        public string PdfUrl { get; set; }
        public string PublicInspectionUrl { get; set; }
        public string PublicationDate { get; set; }
        public List<Agency> Agencies { get; set; }
        public string Excerpts { get; set; }

        public Document(string type, string abstractStr, string title, string documentNumber, string htmlUrl, string pdfUrl, string publicInspectionUrl, string publicationDate, string excerpts)
        {
            Type = type;
            Abstract = abstractStr;
            Title = title;
            DocumentNumber = documentNumber;
            HtmlUrl = htmlUrl;
            PdfUrl = pdfUrl;
            PublicInspectionUrl = publicInspectionUrl;
            PublicationDate = publicationDate;
            Excerpts = excerpts;
            Agencies = new List<Agency>();
        }

        public override string ToString()
        {
            return $"#{nameof(Document)}\n {nameof(Title)}: {Title}\n {nameof(Type)}: {Type}\n{nameof(Abstract)}: {Abstract}\n {nameof(DocumentNumber)}: {DocumentNumber}\n {nameof(PdfUrl)}: {PdfUrl}\n {nameof(HtmlUrl)}: {HtmlUrl}\n {nameof(PublicInspectionUrl)}: {PublicInspectionUrl}\n {nameof(PublicationDate)}: {PublicationDate}\n {nameof(Excerpts)}: {Excerpts}\n {nameof(Agencies)}: {Agencies}";
        }
    }
}