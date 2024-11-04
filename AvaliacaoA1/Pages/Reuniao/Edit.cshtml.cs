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

namespace AvaliacaoA1.Pages.Reuniao
{
    public class EditModel : PageModel
    {
        private readonly AvaliacaoA1Context _context;

        public EditModel(AvaliacaoA1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Reuniao Reuniao { get; set; } = default!;

        [BindProperty]
        public List<int> SelectedMembros { get; set; } = new List<int>();

        public List<SelectListItem> Membros { get; set; } = new List<SelectListItem>();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reuniao = await _context.Reuniao
                .Include(r => r.MembroReunioes)
                .ThenInclude(mr => mr.Membro)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Reuniao == null)
            {
                return NotFound();
            }

            // Carrega todos os membros para a lista de seleção
            Membros = await _context.Membro
                .Select(m => new SelectListItem
                {
                    Value = m.Id.ToString(),
                    Text = m.Nome
                }).ToListAsync();

            // Seleciona os membros já associados à reunião
            SelectedMembros = Reuniao.MembroReunioes.Select(mr => mr.MembroId).ToList();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // Recarrega os membros se o modelo for inválido
                Membros = await _context.Membro
                    .Select(m => new SelectListItem
                    {
                        Value = m.Id.ToString(),
                        Text = m.Nome
                    }).ToListAsync();
                return Page();
            }

            // Atualiza a reunião
            _context.Attach(Reuniao).State = EntityState.Modified;

            // Atualiza os membros associados à reunião
            var existingMembroReunioes = _context.MembroReunioes
                .Where(mr => mr.ReuniaoId == Reuniao.Id)
                .ToList();

            _context.MembroReunioes.RemoveRange(existingMembroReunioes);

            if (SelectedMembros.Any())
            {
                Reuniao.MembroReunioes = SelectedMembros.Select(membroId => new MembroReuniao
                {
                    MembroId = membroId,
                    ReuniaoId = Reuniao.Id
                }).ToList();
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReuniaoExists(Reuniao.Id))
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

        private bool ReuniaoExists(int id)
        {
            return _context.Reuniao.Any(e => e.Id == id);
        }
    }
}
