using Dapper;
using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Controllers
{
    public class TiposCuentasController: Controller
    {
        public TiposCuentasController() 
        {
            
        }
        public IActionResult Crear()
        {
            using (var conection = new SqlConnection(connectionString)) 
            {
                var query = conection.Query("SELECT 1").FirstOrDefault();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }

            return View();
        }
    }
}
