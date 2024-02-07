namespace PokeApi.Models
{
    public class Result
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }

    public class Root
    {
        public List<Result> Results { get; set; }
    }


}
