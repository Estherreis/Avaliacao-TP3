using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Pontuacao
{
    public class CreateModel : PageModel
    {
        private readonly AvaliacaoA1.Data.AvaliacaoA1Context _context;

        public CreateModel(AvaliacaoA1.Data.AvaliacaoA1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TarefaId"] = new SelectList(_context.Tarefa, "Id", "Nome");
            return Page();
        }

        [BindProperty]
        public Models.Pontuacao Pontuacao { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Pontuacao.Tarefa = _context.Tarefa.Find(Pontuacao.TarefaId);
            _context.Pontuacao.Add(Pontuacao);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
