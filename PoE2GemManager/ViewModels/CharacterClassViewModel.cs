using PoE2GemManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE2GemManager.ViewModels
{
    public class CharacterClassViewModel
    {
        public ObservableCollection<CharacterClass> CharacterClasses { get; set; }

        private CharacterClass _selectedCharacterClass;
        public CharacterClass SelectedCharacterClass
        {
            get { return _selectedCharacterClass; }
            set { _selectedCharacterClass = value; }
        }   

        public CharacterClassViewModel()
        {
            CharacterClasses = new ObservableCollection<CharacterClass>()
            {
                new() { Name = "Warrior" },
                new() { Name = "Sorceress" },
                new() { Name = "Ranger" },
                new() { Name = "Monk" },
                new() { Name = "Mercenary" },
                new() { Name = "Witch" }
            };
        }
    }
}
