﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoundGenius.Data;
using SoundGenius.Models;

namespace SoundGenius.Controllers

{
    [Authorize]
    public class ArtistasController : Controller
    {
        private readonly SoundGeniusDB db;

        public ArtistasController(SoundGeniusDB context)
        {
            db = context;
        }



        // GET: Faixas
        public async Task<IActionResult> Index()
        {
            // em SQL, db.music.ToListAsync() sigGeneroica:
            // SELECT * FROM Faixas

            return View(await db.Artista.ToListAsync());
        }




        // GET: Faixas/Details/5
        /// <summary>
        /// Mostra os detalhes de um Dono
        /// </summary>
        /// <param name="id">identificador do Dono a detalhar</param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            // em SQL, db.Faixas.FirstOrDefaultAsync(m => m.ID == id) sigGeneroica
            // SELECT * FROM Faixas d WHERE d.ID = id
            var artista = await db.Artista.FirstOrDefaultAsync(d => d.ID == id);
            if (artista == null)
            {
                return RedirectToAction("Index");
            }

            return View(artista);
        }

        // GET: Faixas/Add
        public IActionResult Add()
        {
            return View();
        }



        // POST: Faixas/Add
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("ID,Nome,Sexo,FicheiroImg")]Artista artista, IFormFile fotoArtista)
        {

            if (ModelState.IsValid)
            {
                db.Add(artista);
                await db.SaveChangesAsync(); // commit
                return RedirectToAction(nameof(Index));
            }

            // alguma coisa correu mal.
            // devolve-se o controlo da aplicação à View
            return View(artista);
        }




        // GET: Faixas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var artista = await db.Artista.FindAsync(id);
            if (artista == null)
            {
                return RedirectToAction("Index");
            }
            return View(artista);
        }


        // POST: Faixas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Sexo,FicheiroImg")] Artista artistas)
        {
            if (id != artistas.ID)
            {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(artistas);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtistasExists(artistas.ID))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(artistas);
        }



        // GET: Faixas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var artista = await db.Artista
                .FirstOrDefaultAsync(m => m.ID == id);
            if (artista == null)
            {
                return RedirectToAction("Index");
            }

            return View(artista);
        }



        // POST: Faixas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artistas = await db.Artista.FindAsync(id);
            db.Artista.Remove(artistas);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        private bool ArtistasExists(int id)
        {
            return db.Artista.Any(e => e.ID == id);
        }
    }
}
