namespace Vention.Internship.CsvParser.Service.Exceptions
{
    public class CsvParserException : Exception
    {
        public int Code { get; set; }
        public CsvParserException(int code, string message)
            : base(message)
        {
            this.Code = code;
        }
    }
}
