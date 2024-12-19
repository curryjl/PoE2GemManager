# If the left hand side is null, use the right hand side
SupportGems = Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<SupportGem>>(json) 
    ?? new ObservableCollection<SupportGem>();