using PoE2GemManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE2GemManager.ViewModels
{
    public class SkillGemViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<SkillGem> SkillGems { get; set; }

        private SkillGem? _selectedSkillGem;
        public SkillGem? SelectedSkillGem
        {
            get { return _selectedSkillGem; }
            set { 
                _selectedSkillGem = value; 
                OnPropertyChanged(nameof(SelectedSkillGem));
                SelectedSkillGemText = UpdateSelectedSkillGemText();
            }
        }

        private string _selectedSkillGemText = string.Empty;
        public string SelectedSkillGemText
        {
            get { return _selectedSkillGemText; }
            set { 
                _selectedSkillGemText = value; 
                OnPropertyChanged(nameof(SelectedSkillGemText));
            }
        }


        public SkillGemViewModel()
        {
            var path = "./Json/SkillGems.json";
            //var path = System.IO.Path.Combine(Environment.CurrentDirectory, "Json", "SkillGems.json");
            var json = System.IO.File.ReadAllText(path);

            SkillGems = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<SkillGem>>(json) ?? new ObservableCollection<SkillGem>();
        }

        public string UpdateSelectedSkillGemText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{SelectedSkillGem?.Name}");
            sb.AppendLine($"{GetSkillGemTags(SelectedSkillGem)}");

            if (SelectedSkillGem?.Level != null)
                sb.AppendLine($"Level: {SelectedSkillGem?.Level}");

            if (SelectedSkillGem?.Cost != null)
                sb.AppendLine($"Cost: {SelectedSkillGem?.Cost}");

            if (SelectedSkillGem?.AttackTime != null)
                sb.AppendLine($"Attack Time: {SelectedSkillGem?.AttackTime}");

            if (SelectedSkillGem?.Requirements != null)
                sb.AppendLine($"Requires: {GetSkillGemRequirements(SelectedSkillGem)}");

            if (SelectedSkillGem?.Effects != null)
                sb.AppendLine($"{GetSkillGemEffects(SelectedSkillGem)}");

            sb.AppendLine($"{SelectedSkillGem?.Description}");

            return sb.ToString();
        }

        // This is triggered when a property is changed AND
        // the WPF binding system subscribes to this event
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string GetSkillGemTags(SkillGem? SelectedSkillGem)
        {
            if (SelectedSkillGem == null)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (var tag in SelectedSkillGem.Tags)
            {
                sb.Append($"{tag}");
                if (tag != SelectedSkillGem.Tags.Last())
                    sb.Append(", ");
            }
            return sb.ToString();
        }

        private string GetSkillGemRequirements(SkillGem? SelectedSkillGem)
        {
            if (SelectedSkillGem == null || SelectedSkillGem.Requirements == null)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (var req in SelectedSkillGem.Requirements)
            {
                sb.Append($"{req}");
                if (req != SelectedSkillGem.Requirements.Last())
                    sb.Append(", ");
            }
            return sb.ToString();
        }

        private string GetSkillGemEffects(SkillGem? SelectedSkillGem)
        {
            if (SelectedSkillGem == null || SelectedSkillGem.Effects == null)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (var req in SelectedSkillGem.Effects)
            {
                sb.AppendLine($"- {req}");
            }
            return sb.ToString();
        }
    }
}
