

using StockManagement.ConsoleUI.Data;
using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Service;

public class CategoryService
{
    CategoryData categoryData = new CategoryData();

    public void GetAll()
    {
        List<Category> categories = categoryData.GetAll();

        foreach (Category category in categories)
        {
            Console.WriteLine(category);
        }
    }

    public void GetById(int id)
    {
        Category? category = categoryData.GetById(id);
        Console.WriteLine($"Aranan kategori id si: {id}");
        Console.WriteLine(category);
    }
    public void Add(Category category)
    {
        categoryData.Add(category);
        Console.WriteLine($"kategori eklendi! {category}");
    }


}
