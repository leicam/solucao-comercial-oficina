using Oficina.Dominio.nsInterfaces.nsRepositorios;

namespace Oficina.Servico.nsClasses
{
    public class AbstractServico
    {
        protected IUnitOfWork UnitOfWork { get; private set; }

        public AbstractServico(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}