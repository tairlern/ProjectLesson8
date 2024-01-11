namespace Project_api.Models
{
    public class OrderPostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountProdact { get; set; }
        //public Product Product { get; set; }
        public DateTime DateOrder { get; set; }

    }
}
