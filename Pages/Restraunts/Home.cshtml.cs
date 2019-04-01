using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace PluralSightASP.NET.Pages.Restraunts
{
    public class HomeModel : PageModel
    {
        private readonly IConfiguration Config;

        public HomeModel(IConfiguration configuration)
        {
            this.Config = configuration;
        }
        public string Message { get; set; }
        public void OnGet()
        {
            Message = Config["Message"];
        }
    }
}