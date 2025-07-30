using System;
using Microsoft.Extensions.Logging;

namespace WebAPIRandomNumberGeneratorProject
{
    public class CodigoGenerador(ILogger<CodigoGenerador> logger) : ICodigoGenerador
    {
        private readonly Random _random = new();
        private readonly ILogger<CodigoGenerador> _logger = logger;

        public string GenerarCodigo(string prefijo)
        {
            int numero = _random.Next(1000, 10000);
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            string codigo = $"{prefijo.ToUpper()}-{fecha}-{numero}";
            _logger.LogInformation("Código generado: {Codigo}", codigo);
            return codigo;
        }
    }
}
