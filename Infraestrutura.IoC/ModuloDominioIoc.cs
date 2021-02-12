using Dominio.Servicos;
using Interfaces.Dominio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.IoC
{
    public static class ModuloDominioIoc
    {
        public static void AddServicosDeDominio(this IServiceCollection services)
        {
            services.AddScoped<IServicoDeDominioDeConsultaDeTaxaDeJuros, ServicoDeDominioDeConsultaDeTaxaDeJuros>();
        }
    }
}
