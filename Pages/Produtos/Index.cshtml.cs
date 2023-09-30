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
    public class IndexModel : PageModel
    {
        private readonly ControleVendas.Data.ApplicationDbContext _context;

        public IndexModel(ControleVendas.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.produtos != null)
            {
                Produto = await _context.produtos.ToListAsync();
            }
        }
    }
}
