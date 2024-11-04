using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Lembrete
{
    public class CreateModel : PageModel
    {
        private readonly AvaliacaoA1Context _context;

        public CreateModel(AvaliacaoA1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Lembrete Lembrete { get; set; } = default!;

        public SelectList Membros { get; set; } = default!;

        public IActionResult OnGet()
        {
            // Carrega todos os membros para o dropdown de seleção única
            Membros = new SelectList(_context.Membro, "Id", "Nome"); // ou "Nome" se preferir exibir o nome

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // Recarrega a lista de membros se o modelo for inválido
                Membros = new SelectList(_context.Membro, "Id", "Nome"); // ou "Nome"

                return Page();
            }

            Lembrete.Membro = _context.Membro.Find(Lembrete.MembroId);
            _context.Lembrete.Add(Lembrete);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
