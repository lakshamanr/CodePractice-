using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApplication.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;


    public string time = DateTime.Now.ToLongDateString();

    [BindProperty]
    public string Message{ get; set; }
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
