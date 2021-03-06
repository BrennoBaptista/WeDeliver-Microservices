﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeDeliver.Microservices.PostagemMicroservice.Domain.AggregatesModel.PostagemAggregate;
using WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Contexts;

namespace WeDeliver.Microservices.PostagemMicroservice.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostagensController : ControllerBase
    {
        private readonly PostagemContext _context;
        private readonly IApiApplicationService _apiApplicationService;

        public PostagensController(PostagemContext context, IApiApplicationService apiApplicationService)
        {
            _context = context;
            _apiApplicationService = apiApplicationService;
        }

        // GET: api/Postagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Postagem>>> GetPostagens()
        {
            return await _context.Postagens.ToListAsync();
        }

        // GET: api/Postagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Postagem>> GetPostagem(Guid id)
        {
            var postagem = await _context.Postagens.FindAsync(id);

            if (postagem == null)
            {
                return NotFound();
            }

            return postagem;
        }

        // PUT: api/Postagens/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostagem(Guid id, Postagem postagem)
        {
            if (id != postagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(postagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostagemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Postagens
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Postagem>> PostPostagem(Postagem postagem)
        {
            //Guid.Parse(User.FindFirst("sub")?.Value);
            await _apiApplicationService.CriarPostagemAsync(postagem.Id_Pacote, postagem.Destino, postagem.Recebedor);

            //_context.Postagens.Add(postagem);
            //await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostagem", new { id = postagem.Id }, postagem);
        }

        // DELETE: api/Postagens/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Postagem>> DeletePostagem(Guid id)
        {
            var postagem = await _context.Postagens.FindAsync(id);
            if (postagem == null)
            {
                return NotFound();
            }

            _context.Postagens.Remove(postagem);
            await _context.SaveChangesAsync();

            return postagem;
        }

        private bool PostagemExists(Guid id)
        {
            return _context.Postagens.Any(e => e.Id == id);
        }
    }
}
