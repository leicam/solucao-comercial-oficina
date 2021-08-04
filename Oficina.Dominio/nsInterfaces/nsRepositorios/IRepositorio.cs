using Oficina.Dominio.nsEntidades;
using System;
using System.Threading.Tasks;

namespace Oficina.Dominio.nsInterfaces.nsRepositorios
{
    public interface IRepositorio<T> where T : AbstractEntidade
    {
        Task AddAsync(T objeto);
        Task RemoveAsync(Guid id);
        void Update(T objeto);
    }
}