//// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
//using Newtonsoft.Json;
//public class Root
//{
//    [JsonProperty("abilities")]
//    public List<Ability> PokemonAbilities { get; set; }

//    [JsonProperty("base_experience")]
//    public int? BaseExperience { get; set; }

//    [JsonProperty("height")]
//    public int? Height { get; set; }

//    [JsonProperty("held_items")]
//    public List<object> HeldItems { get; set; }

//    [JsonProperty("id")]
//    public int? Id { get; set; }

//    [JsonProperty("is_default")]
//    public bool? IsDefault { get; set; }

//    [JsonProperty("location_area_encounters")]
//    public string LocationAreaEncounters { get; set; }

//    [JsonProperty("moves")]
//    public List<Move> Moves { get; set; }

//    [JsonProperty("name")]
//    public string Name { get; set; }

//    [JsonProperty("order")]
//    public int? Order { get; set; }

//    [JsonProperty("past_abilities")]
//    public List<object> PastAbilities { get; set; }

//    [JsonProperty("past_types")]
//    public List<object> PastTypes { get; set; }


//    [JsonProperty("types")]
//    public List<Type> Types { get; set; }

//    [JsonProperty("weight")]
//    public int? Weight { get; set; }
//}

//public class Ability
//{
//    [JsonProperty("ability")]
//    public Ability PokemonAbility { get; set; }

//}

//public class Move
//{
//    [JsonProperty("move")]
//    public Move PokemonMove { get; set; }

//}

//public class Type
//{
//    [JsonProperty("slot")]
//    public int? Slot { get; set; }

//    [JsonProperty("type")]
//    public Type PokemonType { get; set; }
//}

//public class Type2
//{
//    [JsonProperty("name")]
//    public string Name { get; set; }

//    [JsonProperty("url")]
//    public string Url { get; set; }
//}
