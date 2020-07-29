using DevIO.Api.Controllers;
using DevIO.Business.Intefaces;
using DevIO.Business.Interfaces;
using Elmah.Io.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DevIO.Api.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController
    {
        private readonly ILogger _logger;
        public TesteController(INotificador notificador,
                               IUser appUser,
                               ILogger<TesteController> logger) : base(notificador, appUser)
        {
            _logger = logger;
        }
        [HttpGet]
        public string Valor()
        {
            throw new System.Exception("deu ruim");

            //try
            //{
            //    var i = 0;
            //    var result = 42 / i;

            //}
            //catch (DivideByZeroException e)
            //{
            //    e.Ship(HttpContext);
            //}


            _logger.LogTrace("log de Trace");
            _logger.LogDebug("log de Debug");
            _logger.LogInformation("log de Informação");
            _logger.LogWarning("log de Aviso");
            _logger.LogError("log de Erro");
            _logger.LogCritical("log de Problema Crítico");

            return "Sou a v2";
        }
    }
}
