namespace PokeApi.Models
{
    public class Result
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }

    public class Root
    {
        public int? Count { get; set; }

        public string Next { get; set; }

        public object Previous { get; set; }

        public List<Result> Results { get; set; }
    }


}
