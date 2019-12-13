using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;
using CoreWebAppTest.Data;

namespace CoreWebAppTest.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly CoreWebAppTest.Data.dbContext _context;

        public IndexModel(CoreWebAppTest.Data.dbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
