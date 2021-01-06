using System.Collections.Generic;

namespace SystemsUnderTest.Model
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public List<string> Authors { get; set; } = new List<string>();
    }
}
