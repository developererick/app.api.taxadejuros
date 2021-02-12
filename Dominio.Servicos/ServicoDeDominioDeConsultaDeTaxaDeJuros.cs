using Interfaces.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Servicos
{
    public class ServicoDeDominioDeConsultaDeTaxaDeJuros : IServicoDeDominioDeConsultaDeTaxaDeJuros
    {
        public decimal ConsultarTaxaDeJuros()
        {
            return 0.01M;
        }
    }
}
