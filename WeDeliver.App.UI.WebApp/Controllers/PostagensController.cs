using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeDeliver.App.Application;
using WeDeliver.App.Domain.Postagens;

namespace WeDeliver.App.UI.WebApp.Controllers
{
    public class PostagensController : Controller
    {
        private readonly IAppService _appService;

        public PostagensController(IAppService appService)
        {
            _appService = appService;
        }

        //Mostra todos as postagens cadastrados
        // GET: Postagens
        public async Task<IActionResult> Index()
        {
            var postagens = await _appService.GetAllPostagensAsync();
            return View(postagens);
        }

        //Mostra os detalhes de uma postagem
        // GET: Postagens/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postagem = await _appService.GetPostagemAsync(id);

            if (postagem == null)
            {
                return NotFound();
            }

            return View(postagem);
        }

        // GET: Postagens/Create
        public IActionResult Create()
        {
            return View();
        }

        //Cria um nova postagem
        // POST: Postagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Pacote,Destino,Recebedor,DataEnvio,Id")] Postagem postagem)
        {
            if (ModelState.IsValid)
            {
                postagem.Id = Guid.NewGuid();
                await _appService.AdicionarPostagemAsync(postagem);
                return RedirectToAction(nameof(Index));
            }
            return View(postagem);
        }

        // GET: Postagens/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postagem = await _appService.GetPostagemAsync(id);

            if (postagem == null)
            {
                return NotFound();
            }
            return View(postagem);
        }

        //Edita o registro de uma postagem
        // POST: Postagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_Pacote,Destino,Recebedor,DataEnvio,Id")] Postagem postagem)
        {
            if (id != postagem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _appService.UpdatePostagem(postagem);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostagemExists(postagem.Id))
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
            return View(postagem);
        }

        // GET: Postagens/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postagem = await _appService.GetPostagemAsync(id);

            if (postagem == null)
            {
                return NotFound();
            }

            return View(postagem);
        }

        //Deleta uma postagem
        // POST: Postagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _appService.DeletePostagemAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Verifica se uma postagem existe
        private bool PostagemExists(Guid id)
        {
            return (_appService.GetPostagemAsync(id) != null);
        }
    }
}
