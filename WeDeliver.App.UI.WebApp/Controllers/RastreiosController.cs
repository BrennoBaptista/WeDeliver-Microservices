using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeDeliver.App.Application;
using WeDeliver.App.Domain.Rastreios;

namespace WeDeliver.App.UI.WebApp.Controllers
{
    public class RastreiosController : Controller
    {
        private readonly IAppService _appService;

        public RastreiosController(IAppService appService)
        {
            _appService = appService;
        }

        //Mostra todos os rastreios cadastrados
        // GET: Rastreios
        public async Task<IActionResult> Index()
        {
            var rastreios = await _appService.GetAllRastreiosAsync();
            return View(rastreios);
        }

        //Mostra os detalhes de um rastreio
        // GET: Rastreios/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rastreio = await _appService.GetRastreioAsync(id);

            if (rastreio == null)
            {
                return NotFound();
            }

            return View(rastreio);
        }

        // GET: Rastreios/Create
        public IActionResult Create()
        {
            return View();
        }

        //Cria um novo rastreio
        // POST: Rastreios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Postagem,Id_Pacote,StatusEnvio,Localizacao,UltimaAtualizacao,Id")] Rastreio rastreio)
        {
            if (ModelState.IsValid)
            {
                rastreio.Id = Guid.NewGuid();
                await _appService.AdicionarRastreioAsync(rastreio);
                return RedirectToAction(nameof(Index));
            }
            return View(rastreio);
        }

        // GET: Rastreios/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rastreio = await _appService.GetRastreioAsync(id);

            if (rastreio == null)
            {
                return NotFound();
            }
            return View(rastreio);
        }

        //Edita o registro de um rastreio
        // POST: Rastreios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_Postagem,Id_Pacote,StatusEnvio,Localizacao,UltimaAtualizacao,Id")] Rastreio rastreio)
        {
            if (id != rastreio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appService.UpdateRastreio(rastreio);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RastreioExists(rastreio.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rastreio);
        }

        // GET: Rastreios/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rastreio = await _appService.GetRastreioAsync(id);

            if (rastreio == null)
            {
                return NotFound();
            }

            return View(rastreio);
        }

        //Deleta um rastreio
        // POST: Rastreios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appService.DeleteRastreioAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Verifica se um rastreio existe
        private bool RastreioExists(Guid id)
        {
            return (_appService.GetRastreioAsync(id) != null);
        }
    }
}
