using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages;
public class Categories : PageModel
{
    public List<Category> CategoryList { get; set; } = new();

    public void OnGet(int skip = 0, int take = 25)
    {
        var categories = new List<Category>();

        for (int i = 1; i <= 10000; i++)
        {
            categories.Add(new Category(i, $"Categoria {i}", i * 18.95M));
        }

        CategoryList = categories.Skip(skip).Take(take).ToList();
    }

    public void OnPost()
    {

    }

}

public record Category(int Id, string Title, decimal Price);
