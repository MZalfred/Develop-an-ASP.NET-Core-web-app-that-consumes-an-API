using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyAspNetApp.Pages
{
    public class TreasurePageModel : PageModel
    {
        public required string ApiTreasure { get; set; }

        public async Task OnGetAsync()
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
            ApiTreasure = await response.Content.ReadAsStringAsync();
        }
    }
}
