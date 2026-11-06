namespace SearchDemonSlayerAPI.Models
{
    public class Character
    {
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Race { get; set; }
        public string? Quote { get; set; }
        public string? Img { get; set; }
    }

    public class ApiResponse
    {
        public List<Character>? Data { get; set; }
    }
}