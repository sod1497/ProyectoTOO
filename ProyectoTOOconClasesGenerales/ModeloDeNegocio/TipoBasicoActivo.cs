using System;

namespace ModeloDeDominio
{
    public interface TipoBasicoActivo : ModeloDeDominio.TipoBasico
    {

        bool EstaActivo { get; set; }

    }
}
