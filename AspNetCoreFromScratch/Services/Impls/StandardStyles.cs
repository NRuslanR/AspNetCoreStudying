using AspNetCoreFromScratch.Services;

namespace AspNetCoreFromScratch.Services.Impls
{
    public class StandardStyles : IStyles
    {
        public string headerWrap(string text, HeaderLevel headerLevel, string style = "")
        {
            return $"<{headerLevel} style='{style}'>{text}</{headerLevel}>";
        }

        public string paragraphWrap(string text, string style = "")
        {
            return $"<p style='{style}'>{text}</p>";
        }
    }
}