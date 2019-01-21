namespace Books.Api.Models
{
    public class BookCover
    {
        public string Name { get; set; }
        
        // don't return the bytes for the demo to avoid
        // long waiting times
        //  public byte[] Content { get; set; }
    }
}
