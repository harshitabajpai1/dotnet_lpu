using System.Collections.Generic;
public enum Category{Electronics, Clothing, Books, Groceries}

public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new List<T>();

    public void AddProduct(T product)
    {
        if(!_products.Any(x => x.Id == product.Id ) && product.Price>0 && product.Name!= null)
        {
            _products.Add(product);
        }
    }

    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        
    }

    public decimal CalculateTotalValue()
    {
        decimal total = _products.Sum(x => x.Price);
        return total;
        
    }
}