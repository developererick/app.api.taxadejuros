using Dominio.Servicos;
using Interfaces.Aplicacao;
using Interfaces.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Servicos
{
    public class ServicoDeAplicacaoDeConsultaDeTaxaDeJuros : IServicoDeAplicacaoDeConsultaDeTaxaDeJuros
    {
        private readonly IServicoDeDominioDeConsultaDeTaxaDeJuros _servicoDeDominioDeConsultaDeTaxaDeJuros;
        public ServicoDeAplicacaoDeConsultaDeTaxaDeJuros()
        {
            _servicoDeDominioDeConsultaDeTaxaDeJuros = new ServicoDeDominioDeConsultaDeTaxaDeJuros();
        }
        public decimal ConsultarTaxaDeJuros()
        {
            return _servicoDeDominioDeConsultaDeTaxaDeJuros.ConsultarTaxaDeJuros();
        }
    }
}
