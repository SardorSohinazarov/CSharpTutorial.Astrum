namespace CRUDWithFile.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }

        public Address Address { get; set; }
    }

    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Cordinate Cordinate { get; set; }
    }

    public class Cordinate
    {
        public decimal Long { get; set; }
        public decimal Lat { get; set; }
    }


    /*
    {
        "Id":1,
        "Title":"Sardor",
        "AuthorName":"Sardor2",
        "Genre":"Romatic",
        "Address":{
            "Country":"Uzbekistan",
            "City":"Tashkent",
            "Street":"Tashkent",
            "Cordinate":{
                    "Long":123.123,
                    "Lat":123.123
                }
        }
    }
     */
}
