using System.Collections.Generic;

namespace Hadouken.Plugins.AutoAdd.Models
{
    public class Folder
    {
        public Folder()
        {
            Filters = new List<Filter>();
        }

        public string Path { get; set; }

        public bool Enabled { get; set; }

        public IList<Filter> Filters { get; set; }
    }
}
