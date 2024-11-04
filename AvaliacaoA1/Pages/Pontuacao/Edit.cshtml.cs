using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Pontuacao
{
    public class EditModel : PageModel
    {
        private readonly AvaliacaoA1.Data.AvaliacaoA1Context _context;

        public EditModel(AvaliacaoA1.Data.AvaliacaoA1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Pontuacao Pontuacao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pontuacao =  await _context.Pontuacao.FirstOrDefaultAsync(m => m.Id == id);
            if (pontuacao == null)
            {
                return NotFound();
            }
            Pontuacao = pontuacao;
           ViewData["TarefaId"] = new SelectList(_context.Tarefa, "Id", "Nome");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pontuacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PontuacaoExists(Pontuacao.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PontuacaoExists(int id)
        {
            return _context.Pontuacao.Any(e => e.Id == id);
        }
    }
}
