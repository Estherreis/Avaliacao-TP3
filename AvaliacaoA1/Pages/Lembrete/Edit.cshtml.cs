using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AvaliacaoA1.Pages.Lembrete
{
    public class EditModel : PageModel
    {
        private readonly AvaliacaoA1Context _context;

        public EditModel(AvaliacaoA1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Lembrete Lembrete { get; set; } = default!;

        public SelectList Membros { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lembrete = await _context.Lembrete.Include( x => x.Membro).FirstOrDefaultAsync(m => m.Id == id);
            if (Lembrete == null)
            {
                return NotFound();
            }

            // Carrega a lista de membros para o dropdown
            Membros = new SelectList(_context.Membro, "Id", "Nome"); // ou "Nome" se preferir mostrar o nome

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // Recarrega a lista de membros se o modelo for inválido
                Membros = new SelectList(_context.Membro, "Id", "Email"); // ou "Nome"
                return Page();
            }

            _context.Attach(Lembrete).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LembreteExists(Lembrete.Id))
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

        private bool LembreteExists(int id)
        {
            return _context.Lembrete.Any(e => e.Id == id);
        }
    }
}
