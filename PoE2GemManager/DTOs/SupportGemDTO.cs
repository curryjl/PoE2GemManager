using PoE2GemManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE2GemManager.DTOs
{
    public class SupportGemDTO
    {
        public required string Name { get; set; }
        public required string Description { get; set; }

        public required string? Tags { get; set; }

        public string? Requirements { get; set; }
        public string? Effects { get; set; }
        public string? Tabs { get; set; }
    }
}
