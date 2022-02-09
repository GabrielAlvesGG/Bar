using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bar.Models;

namespace BarControllers
{
    public class BarController  : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroCliente() 
        {   
            BarRepository br = new BarRepository();
            br.InserirCliente();
            return View();
        }
    }
}