namespace PoE2GemManager.Models
{
    public class SkillGem : Gem
    {
        public string? AttackTime { get; set; }
        public int? Level { get; set; }
        public int AttackDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int? Cost { get; set; }
        public IEnumerable<SupportGem>? SupportGems { get; set; }
    }
}
