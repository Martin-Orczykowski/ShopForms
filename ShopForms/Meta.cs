namespace ShopForms
{
    public class Rootobject
    {
        public Meta meta { get; set; }
        public Product[] products { get; set; }
    }

    public class Meta
    {
        public int count { get; set; }
        public int limit { get; set; }
        public int page { get; set; }
        public string next_url { get; set; }
    }

    public class Product
    {
        public string name { get; set; }
        public string product_url { get; set; }
        public float price { get; set; }
        public string photo_url { get; set; }
        public string category_url { get; set; }
        public string vendor_url { get; set; }
    }

    public class Kategorie
    {
        public string name { get; set; }
        public Product[] products { get; set; }
    }


    public class Hersteller
    {
        public string name { get; set; }
        public string products_url { get; set; }
    }

}


