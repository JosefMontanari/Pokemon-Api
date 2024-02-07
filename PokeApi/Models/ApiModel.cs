namespace PokeApi.Models
{
    public class Root
    {
        public List<Result> Result { get; set; }
    }
    public class Result
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }
}
