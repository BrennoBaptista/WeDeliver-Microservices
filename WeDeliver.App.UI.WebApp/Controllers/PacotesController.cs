using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeDeliver.App.Application;
using WeDeliver.App.Domain.Pacotes;

namespace WeDeliver.App.UI.WebApp.Controllers
{
    public class PacotesController : Controller
    {
        private readonly IAppService _appService;

        public PacotesController(IAppService appService)
        {
            _appService = appService;
        }

        //Mostra todos os pacotes cadastrados
        // GET: Pacotes
        public async Task<IActionResult> Index()
        {
            var pacotes = await _appService.GetAllPacotesAsync();
            return View(pacotes);
        }

        //Mostra os detalhes de um pacote
        // GET: Pacotes/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacote = await _appService.GetPacoteAsync(id);

            if (pacote == null)
            {
                return NotFound();
            }

            return View(pacote);
        }

        // GET: Pacotes/Create
        public IActionResult Create()
        {
            return View();
        }

        //Cria um novo pacote
        // POST: Pacotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Cliente,Peso,Altura,Largura,Profundidade,Id")] Pacote pacote)
        {
            if (ModelState.IsValid)
            {
                pacote.Id = Guid.NewGuid();
                await _appService.AdicionarPacoteAsync(pacote);
                return RedirectToAction(nameof(Index));
            }
            return View(pacote);
        }

        // GET: Pacotes/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacote = await _appService.GetPacoteAsync(id);

            if (pacote == null)
            {
                return NotFound();
            }
            return View(pacote);
        }

        //Edita o registro de um pacote
        // POST: Pacotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_Cliente,Peso,Altura,Largura,Profundidade,Id")] Pacote pacote)
        {
            if (id != pacote.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appService.UpdatePacote(pacote);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacoteExists(pacote.Id))
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
            return View(pacote);
        }

        // GET: Pacotes/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacote = await _appService.GetPacoteAsync(id);

            if (pacote == null)
            {
                return NotFound();
            }

            return View(pacote);
        }

        //Deleta um cliente
        // POST: Pacotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appService.DeletePacoteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Verifica se um pacote existe
        private bool PacoteExists(Guid id)
        {
            return (_appService.GetPacoteAsync(id) != null);
        }
    }
}
