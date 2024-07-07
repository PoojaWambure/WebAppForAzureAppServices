using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppForAzureAppServices.Pages
{
    public class QuotesModel : PageModel
    {
        private readonly ILogger<QuotesModel> _logger;

        public QuotesModel(ILogger<QuotesModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
