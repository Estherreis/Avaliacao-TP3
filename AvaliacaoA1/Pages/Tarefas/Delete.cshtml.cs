using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Tarefas
{
    public class DeleteModel : PageModel
    {
        private readonly AvaliacaoA1.Data.AvaliacaoA1Context _context;

        public DeleteModel(AvaliacaoA1.Data.AvaliacaoA1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Tarefa Tarefa { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = await _context.Tarefa.FindAsync(id);
            if (tarefa != null)
            {
                Tarefa = tarefa;
                _context.Tarefa.Remove(Tarefa);
                await _context.SaveChangesAsync();
            }

            return new JsonResult(true);
        }
    }
}
