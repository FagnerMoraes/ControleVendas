using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ControleVendas.Data;
using ControleVendas.Models;

namespace ControleVendas.Pages_Produtos
{
    public class DeleteModel : PageModel
    {
        private readonly ControleVendas.Data.ApplicationDbContext _context;

        public DeleteModel(ControleVendas.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Produto Produto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.produtos.FirstOrDefaultAsync(m => m.Id == id);

            if (produto == null)
            {
                return NotFound();
            }
            else 
            {
                Produto = produto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.produtos == null)
            {
                return NotFound();
            }
            var produto = await _context.produtos.FindAsync(id);

            if (produto != null)
            {
                Produto = produto;
                _context.produtos.Remove(Produto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
