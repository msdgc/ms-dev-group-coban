using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcApp1.Models;

namespace mvcApp1.Controllers
{
    public class PersonasController : Controller
    {
        private readonly ILogger<PersonasController> _logger;

        public PersonasController(ILogger<PersonasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
