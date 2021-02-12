using Aplicacao.Servicos;
using Interfaces.Aplicacao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxaDeJuros.API.Controllers
{
    [Route("api/v1/juros")]
    [ApiController]
    public class JurosController : ControllerBase
    {

        private readonly IServicoDeAplicacaoDeConsultaDeTaxaDeJuros _servicoDeAplicacaoDeConsultaDeTaxaDeJuros;
        public JurosController(IServicoDeAplicacaoDeConsultaDeTaxaDeJuros servicoDeAplicacaoDeConsultaDeTaxaDeJuros)
        {
            this._servicoDeAplicacaoDeConsultaDeTaxaDeJuros = servicoDeAplicacaoDeConsultaDeTaxaDeJuros;
        }

        [HttpGet("taxajuros")]
        public IActionResult GetTaxaDeJuros()
        {
            var taxaJuros = _servicoDeAplicacaoDeConsultaDeTaxaDeJuros.ConsultarTaxaDeJuros();
            return Ok(taxaJuros);
        }
    }
}
