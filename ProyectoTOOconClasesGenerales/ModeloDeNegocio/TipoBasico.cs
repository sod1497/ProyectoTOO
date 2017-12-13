using System;

namespace ModeloDeDominio
{
    public interface TipoBasico
    {
        string Clave { get; }

        TipoBasico copiar();

    }
}