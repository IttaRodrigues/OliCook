using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OliCook.Models;
using OliCook.Data;
using OliCook.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace OliCook.Controllers;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM home = new() {
                Categorias = _context.Categorias
                    .Where(c => c.ExibirHome)
                    .AsNoTracking()
                    .ToList(),
                Receitas = _context.Receitas
                    .Include(r => r.Categoria)
                    .Include(r => r.Ingredientes) //Erro retirei um s
                    .AsNoTracking()
                    .ToList()
            };
            return View(home);
        }

        public IActionResult Receita(int id)
        {
            Receita receita = _context.Receitas
                .Include(r => r.Categoria)
                .Include(r => r.Ingredientes) //retirei um s 
                .ThenInclude(i => i.Ingrediente)
                .AsNoTracking()
                .FirstOrDefault(r => r.Id == id); //erro no Id
            return View(receita);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

