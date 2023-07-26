using System.Net;

namespace Vention.Internship.CsvParser.Service.Exceptions
{
    public class CsvParserException : Exception
    {
        public HttpStatusCode Code { get; set; }
        public CsvParserException(HttpStatusCode code, string message)
            : base(message)
        {
            this.Code = code;
        }
    }
}
