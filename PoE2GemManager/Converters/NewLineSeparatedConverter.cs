using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PoE2GemManager.Converters
{
    class NewLineSeparatedConverter : JsonConverter<IEnumerable<string>>
    {
        private readonly string _separator;

        public NewLineSeparatedConverter(string separator = "\n")
        {
            _separator = separator;
        }

        public override IEnumerable<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value?.Split(_separator, StringSplitOptions.RemoveEmptyEntries) ?? [];
        }

        public override void Write(Utf8JsonWriter writer, IEnumerable<string> value, JsonSerializerOptions options)
        {
            var joinString = string.Join(_separator, value);
            writer.WriteStringValue(joinString);
        }
    }
}
