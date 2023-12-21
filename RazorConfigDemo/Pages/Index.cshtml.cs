using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
namespace RazorConfigDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string name { get; set; }
        public string CompanyName { get; set; }
        public IConfiguration _config { get;}
        public IndexModel(IConfiguration config)
        {
           _config=config;
        }

        public void OnGet()
        {
            name = "Sarita ";
            CompanyName = _config["company"];
        }
    }
}
