using System;
using Microsoft.AspNetCore.Mvc;
using SistemaAdminTaller.Models;
using SistemaAdminTaller.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace SistemaAdminTaller.Controllers
{
    public class Vehiculos : Controller
    {
        private readonly ApplicationDbContext _Context;

        public Vehiculos(ApplicationDbContext context)
        {
            _Context = context;
        }

        //GET /Vehiculos/Registrar
        public IActionResult Registrar()
        {
            ViewData["ClienteID"]  = new SelectList(_Context.Cliente, "ID" , "NombreCompleto");
            ViewData["MecanicoID"] = new SelectList(_Context.Mecanicos, "ID", "NombreCompleto");
            return View();
        }

        //POST /Vehiculos/Registrar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registrar(Vehiculo vehiculo)
        {
            if(ModelState.IsValid)
            {
                await _Context.AddAsync(vehiculo);
                await _Context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

    }
}