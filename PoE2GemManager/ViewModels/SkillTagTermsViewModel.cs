using PoE2GemManager.Models.Info;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace PoE2GemManager.ViewModels
{
    public class SkillTagTermsViewModel : INotifyCollectionChanged
    {
        private ObservableCollection<SkillTagTerm> _skillTagTerms { get; set; } = new ObservableCollection<SkillTagTerm>();
        public ObservableCollection<SkillTagTerm> SkillTagTerms
        {
            get { return _skillTagTerms; }
            set
            {
                _skillTagTerms = value;
            }
        }

        public SkillTagTermsViewModel()
        {
            var path = "./Json/SkillTagTerms.json";
            var json = System.IO.File.ReadAllText(path);

            SkillTagTerms = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<SkillTagTerm>>(json)
                ?? new ObservableCollection<SkillTagTerm>();
        }

        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public void Filter(string s)
        {
            var filteredSkillTagTerms = SkillTagTerms.Where(st => !st.Term.Contains(s) || !st.Definition.Contains(s));
            SkillTagTerms = new ObservableCollection<SkillTagTerm>(filteredSkillTagTerms);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

    }
}
