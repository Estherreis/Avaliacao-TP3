using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Recompensa
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
        ViewData["MembroId"] = new SelectList(_context.Membro, "Id", "Email");
            return Page();
        }

        [BindProperty]
        public Models.Recompensa Recompensa { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recompensa.Add(Recompensa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
