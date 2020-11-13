namespace AspNetCoreFromScratch.Services
{
    public enum HeaderLevel
    {
        h1,
        h2,
        h3,
        h4,
        h5
    };
    
    public interface IStyles
    {
        string headerWrap(string text, HeaderLevel headerLevel, string style = "");
        string paragraphWrap(string text, string style = "");
    }
}