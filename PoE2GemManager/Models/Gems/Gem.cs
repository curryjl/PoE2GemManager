using System.Text.Json.Serialization;

namespace PoE2GemManager.Models
{
    // why make a class abstract?
    public abstract class Gem
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required IEnumerable<string> Tags { get; set; }
        public IEnumerable<string>? Requirements { get; set; }
        public IEnumerable<string>? Effects { get; set; }
        public IEnumerable<Tabs>? Tabs { get; set; }
    }
}
