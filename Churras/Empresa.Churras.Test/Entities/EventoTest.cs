using Empresa.Churras.Domain.Model.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Churras.Test.Entities
{
    [TestClass]
    public class EventoTest
    {
        [TestMethod]
        public void ConfirmarPresenca_Test()
        {
            var colega = new Colega
            {
                Key = 1,
                Nome = "Pedro"
            };

            var evento = new Evento
            {
                Nome = "Churras na casa do Jovem"
            };
            evento.ConfirmarPresenca(colega);

            var confirmacao = evento.ColegasConfirmados.FirstOrDefault(c => c.ColegaNome == "Pedro");

            Assert.IsNotNull(confirmacao, "Não encontrou o Pedro na lista de confirmados");
            Assert.AreEqual(colega.Key, confirmacao.ColegaKey, $"Confirmação não é do colega com o I: {colega.Key}");
        }

        [TestMethod]
        public void CancelarPresenca_Test()
        {
            var colega = new Colega
            {
                Key = 1,
                Nome = "Pedro"
            };

            var evento = new Evento
            {
                Nome = "Churras na casa do Jovem"
            };
            evento.ConfirmarPresenca(colega);
            evento.CancelarPresenca(colega);

            var confirmacao = evento.ColegasConfirmados.FirstOrDefault(c => c.ColegaNome == "Pedro");

            Assert.IsNull(confirmacao, "O Pedro ainda está na lista de presença");
        }
    }
}
