using PoE2GemManager.DTOs;
using PoE2GemManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE2GemManager.ViewModels
{
    public class SupportGemViewModel : INotifyPropertyChanged
    {
        private const string _spaceSeparator = ", ";
        private const string _newLineSeparator = "\n";

        private ObservableCollection<SupportGemDTO> _supportGemDto = new();
        public ObservableCollection<SupportGemDTO> SupportGemsDto
        {
            get { return _supportGemDto; }
            set
            {
                SupportGemsDto = value;
                OnPropertyChanged(nameof(SupportGemsDto));
            }
        }


        private ObservableCollection<SupportGem> _supportGems = new();
        public ObservableCollection<SupportGem> SupportGems
        {
            get { return _supportGems; }
            set { 
                _supportGems = value;
                OnPropertyChanged(nameof(SupportGems));
            }
        }

        public SupportGemViewModel()
        {
            var path = "./Json/SupportGems.json";
            var json = System.IO.File.ReadAllText(path);

            // if the left hand side is null, use the right hand side
            SupportGems = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<SupportGem>>(json) 
                ?? new ObservableCollection<SupportGem>();

            ToSupportedGemsDTO(SupportGems);
        }

        private void ToSupportedGemsDTO(ObservableCollection<SupportGem> supportGems)
        {
            foreach (var supportGem in supportGems)
            {
                var supportGemDTO = new SupportGemDTO()
                {
                    Name = supportGem.Name,
                    Description = supportGem.Description,
                    Tags = string.Join(_spaceSeparator, supportGem.Tags),
                    Requirements = string.Join(_spaceSeparator, supportGem.Requirements ?? []),
                    Effects = string.Join(_newLineSeparator, supportGem.Effects ?? [])
                };

                SupportGemsDto.Add(supportGemDTO);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
