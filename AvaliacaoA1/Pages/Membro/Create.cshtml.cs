using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Membro
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
            return Page();
        }

        [BindProperty]
        public Models.Membro Membro { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Membro.Add(Membro);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
