using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Reuniao
{
    public class CreateModel : PageModel
    {
        private readonly AvaliacaoA1Context _context;

        public CreateModel(AvaliacaoA1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            // Carrega todos os membros para serem exibidos na lista de seleção
            Membros = _context.Membro
                .Select(m => new SelectListItem
                {
                    Value = m.Id.ToString(),
                    Text = m.Nome
                }).ToList();

            return Page();
        }

        [BindProperty]
        public Models.Reuniao Reuniao { get; set; } = default!;

        [BindProperty]
        public List<int> SelectedMembros { get; set; } = new List<int>();

        public List<SelectListItem> Membros { get; set; } = new List<SelectListItem>();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Membros = _context.Membro
                    .Select(m => new SelectListItem
                    {
                        Value = m.Id.ToString(),
                        Text = m.Nome
                    }).ToList();
                return Page();
            }

            // Adiciona os membros selecionados à reunião
            if (SelectedMembros.Any())
            {
                Reuniao.MembroReunioes = SelectedMembros.Select(membroId => new MembroReuniao
                {
                    MembroId = membroId
                }).ToList();
            }

            _context.Reuniao.Add(Reuniao);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
