namespace AuthenticationAndAuthorization.Models
{
    public class ProductRepo
    {
        public static List<Product> cosmeticProducts = null;
        public ProductRepo()
        {
            cosmeticProducts = new List<Product>
            {
                new Product{ProductId=1, Name="Lipstick", Cost=19.99M, Description="A long-lasting lipstick that provides vibrant color and a smooth finish.", Category="Makeup", Brand="Luxe Beauty", StockQuantity=100,ImageUrl="/images/Lipstick.png"},
                new Product{ProductId=2, Name="Foundation", Cost=29.99M, Description="A lightweight foundation that offers buildable coverage and a natural finish.", Category="Makeup", Brand="Glow Cosmetics", StockQuantity=150,ImageUrl="/images/Foundation.png"},
                new Product{ProductId=3, Name="Mascara", Cost=14.99M, Description="A volumizing mascara that lengthens and defines lashes for a dramatic look.", Category="Makeup", Brand="Luxe Beauty", StockQuantity=200, ImageUrl="/images/maskara.png"},
                new Product{ProductId=4, Name="Blush", Cost=24.99M, Description="A silky blush that adds a natural flush of color to the cheeks.", Category="Makeup", Brand="Glow Cosmetics", StockQuantity=120, ImageUrl = "/images/blush.png"},
                new Product{ProductId=5, Name="Eyeshadow Palette", Cost=39.99M, Description="A versatile eyeshadow palette with a range of shades for creating endless eye looks.", Category="Makeup", Brand="Luxe Beauty", StockQuantity=80, ImageUrl = "/images/eyeshadow.png"},
                new Product{ProductId=6, Name="Face Cream", Cost=49.99M, Description="A nourishing face cream that hydrates and revitalizes the skin.", Category="Skincare", Brand="Glow Cosmetics", StockQuantity=90, ImageUrl="/images/FaceCream.png"},
            };
        }
        public List<Product> GetAllCosmeticProducts()
        {
            return cosmeticProducts; 
        }
    }
}
