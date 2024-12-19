1. Create a JSON File with Skills Data
2. Deserialize JSON file to C# objects
	- Include Newtonsoft.Json package
	-   string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "Json", "SkillGems.json");
        string jsonData = File.ReadAllText(jsonPath);

        // Deserialize the JSON into a collection of Skill objects
        Skills = JsonConvert.DeserializeObject<ObservableCollection<SkillGem>>(jsonData);