using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Soundgenius.Data;
using Soundgenius.Models;

namespace Soundgenius.Controllers
{
    public class MusicController : Controller
    {
        private readonly SoundgeniusDB db;

        public MusicController (SoundgeniusDB context)
        {
            db = context;
        }

         

        // GET: Faixas
        public async Task<IActionResult> Index()
        {
            // em SQL, db.music.ToListAsync() sigGeneroica:
            // SELECT * FROM Faixas

            return View(await db.Faixas.ToListAsync());
        }




        // GET: Faixas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }


            // em SQL, db.Faixas.FirstOrDefaultAsync(m => m.ID == id) sigGeneroica
            // SELECT * FROM Faixas d WHERE d.ID = id
            var faixa = await db.Faixas.FirstOrDefaultAsync(d => d.ID == id);

            if (faixa == null)
            {
                return RedirectToAction("Index");
            }

            return View(faixa);
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
        public async Task<IActionResult> Add( Faixas faixa)
        {

            if (ModelState.IsValid)
            {
                db.Add(faixa);
                await db.SaveChangesAsync(); // commit
                return RedirectToAction(nameof(Index));
            }

            // alguma coisa correu mal.
            // devolve-se o controlo da aplicação à View
            return View(faixa);
        }




        // GET: Faixas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var faixa = await db.Faixas.FindAsync(id);
            if (faixa == null)
            {
                return RedirectToAction("Index");
            }
            return View(faixa);
        }


        // POST: Faixas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Titulo,Genero,FicheiroImg")] Faixas faixas)
        {
            if (id != faixas.ID)
            {
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(faixas);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaixasExists(faixas.ID))
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
            return View(faixas);
        }



        // GET: Faixas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var faixa = await db.Faixas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (faixa == null)
            {
                return RedirectToAction("Index");
            }

            return View(faixa);
        }



        // POST: Faixas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faixas = await db.Faixas.FindAsync(id);
            db.Faixas.Remove(faixas);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        private bool FaixasExists(int id)
        {
            return db.Faixas.Any(e => e.ID == id);
        }
    }
}
