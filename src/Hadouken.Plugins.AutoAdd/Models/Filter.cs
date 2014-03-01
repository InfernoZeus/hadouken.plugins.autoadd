namespace Hadouken.Plugins.AutoAdd.Models
{
    public class Filter
    {
        public string RegularExpression { get; set; }

        public string Label { get; set; }

        public string SavePath { get; set; }

        public bool AutoStart { get; set; }
    }
}
