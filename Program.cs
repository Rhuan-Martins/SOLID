using SOLID.Interface;
using SOLID.Models;

IProductRepository repository = new ProductRepository();
Inventory inventory = new Inventory(repository);

inventory.AddProduct(new Product {Name = "Computador", Price = 100.40m, QuantityinStock = 2});
inventory.AddProduct(new Product {Name = "Wallif", Price = 900.40m, QuantityinStock = 1});

Console.WriteLine("Produtos em estoque:");
foreach (var product in inventory.ListProducts())
{
    Console.WriteLine($"ID: {product.Id}, Nome: {product.Name}, Preço: {product.Price}, Estoque {product.QuantityinStock}");
}