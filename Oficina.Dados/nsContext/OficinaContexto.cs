using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dados.nsContext
{
    public class OficinaContexto : DbContext
    {
        public OficinaContexto(DbContextOptions<OficinaContexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder model)
        {

            base.OnModelCreating(model);
        }
    }
}
