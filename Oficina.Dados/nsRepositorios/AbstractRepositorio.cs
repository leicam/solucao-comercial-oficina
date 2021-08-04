using Microsoft.EntityFrameworkCore;
using Oficina.Dominio.nsEntidades;
using Oficina.Dominio.nsInterfaces.nsRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dados.nsRepositorios
{
    public class AbstractRepositorio<T> : IRepositorio<T> where T : AbstractEntidade
    {
        protected readonly DbSet<T> Entidade;

        public async Task AddAsync(T objeto)
        {
            objeto.SetDataCadastro();
            await Entidade.AddAsync(objeto);
        }

        public async Task RemoveAsync(Guid id)
            => Entidade.Remove(await Entidade.FindAsync(id));

        public void Update(T objeto)
        {
            objeto.SetDataAtualizacao();
            Entidade.Update(objeto);
        }
    }
}