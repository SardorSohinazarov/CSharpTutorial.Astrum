using System.Text.Json;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, World!");

        var book = new Book()
        {
            Id = 1,
            Title = "Yulduzli tunlar",
            Author = "Primqul Qodirov"
        };

        //Serialization
        var jsonData = JsonSerializer.Serialize(book);

        Console.WriteLine(jsonData);*/


        //Deserialization
        string JSONData = "[\r\n{\r\n\"userId\": 1,\r\n\"id\": 1,\r\n\"title\": \"sunt aut facere repellat provident occaecati excepturi optio reprehenderit\",\r\n\"body\": \"quia et suscipit suscipit recusandae consequuntur expedita et cum reprehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto\"\r\n},\r\n{\r\n\"userId\": 1,\r\n\"id\": 2,\r\n\"title\": \"qui est esse\",\r\n\"body\": \"est rerum tempore vitae sequi sint nihil reprehenderit dolor beatae ea dolores neque fugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis qui aperiam non debitis possimus qui neque nisi nulla\"\r\n},\r\n{\r\n\"userId\": 1,\r\n\"id\": 3,\r\n\"title\": \"ea molestias quasi exercitationem repellat qui ipsa sit aut\",\r\n\"body\": \"et iusto sed quo iure voluptatem occaecati omnis eligendi aut ad voluptatem doloribus vel accusantium quis pariatur molestiae porro eius odio et labore et velit aut\"\r\n}]";

        var postlar = JsonSerializer.Deserialize<List<Post>>(JSONData);

        foreach (var post in postlar)
        {
            Console.WriteLine(post);
        }
    }

    /*   record Post
       {
           [JsonPropertyName("userId")]
           public int UserId { get; init; }
           [JsonPropertyName("id")]
           public int Id { get; init; }
           [JsonPropertyName("title")]
           public string Title { get; init; }
           [JsonPropertyName("body")]
           public string Body { get; init; }
       }*/

    class Post
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }


    class Film
    {
        public int Id { get; set; }
        [JsonPropertyName("Name")]
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}