using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjectRazor.Pages
{
    public class NotFoundModel : PageModel
    {
        public required string FunnyMessage { get; set; }
        private string[] Messages { get; } =
        {
                "Oops! Bu sayfa bir paralel evrene kaçmış olabilir.",
                "404: Sayfanız kayboldu, kahve molası mı versek?",
                "Burada bir şey yok... Belki uzaylılar aldı?",
                "Hata 404: Sayfayı bulamadık, ama seni bulduk!"
            };

        public void OnGet()
        {
            Random rand = new Random();
            FunnyMessage = Messages[rand.Next(Messages.Length)];
        }
    }
}