using Aplicacao.Servicos;
using Interfaces.Aplicacao;
using Microsoft.Extensions.DependencyInjection;


namespace Infraestrutura.IoC
{
    public static class ModuloAplicacaoIoc
    {
        public static void AddServicosDeAplicacao(this IServiceCollection services)
        {
            services.AddScoped<IServicoDeAplicacaoDeConsultaDeTaxaDeJuros, ServicoDeAplicacaoDeConsultaDeTaxaDeJuros>();
        }
    }
}
