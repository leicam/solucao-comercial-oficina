using System;

namespace Oficina.Dominio.nsEntidades
{
    public class AbstractEntidade
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime DataCadastro { get; private set; } = DateTime.MinValue;
        public DateTime DataAtualizacao { get; private set; } = DateTime.MinValue;

        public void SetDataCadastro()
            => DataCadastro = DateTime.UtcNow;

        public void SetDataAtualizacao()
            => DataAtualizacao = DateTime.UtcNow;
    }
}