using Empresa.Churras.Domain.Model.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Churras.Test.ValueObjects
{
    public class PeriodoTest
    {
        [TestMethod]
        public void QuantoDuraEmHoras_Test()
        {
            var periodo = new Periodo
            {
                Inicio = new DateTime(2023, 10, 1, 12, 0, 0),
                Fim = new DateTime(2023, 10, 1, 22, 0, 0)
            };

            int horas = periodo.QuantoDuraEmHoras();

            Assert.AreEqual(10, horas);
        }

        [TestMethod]
        public void FaltaQuantoTempoParaComecar_Dias_Test()
        {
            var dtinicio = DateTime.Now.AddDays(3).AddHours(5);
            var dtFim = dtinicio.AddHours(10);

            var periodo = new Periodo
            {
                Inicio = dtinicio,
                Fim = dtFim
            };

            string quantoFalta = periodo.QuantoFaltaParaComecar();

            Assert.AreEqual("Comeca em 3 dias e 4 horas", quantoFalta);
        }

        [TestMethod]
        public void FaltaQuantoTempoParaComecar_Horas_Test()
        {
            var dtinicio = DateTime.Now.AddHours(5);
            var dtFim = dtinicio.AddHours(10);

            var periodo = new Periodo
            {
                Inicio = dtinicio,
                Fim = dtFim
            };

            string quantoFalta = periodo.QuantoFaltaParaComecar();

            Assert.AreEqual("Comeca em 4 horas", quantoFalta);
        }

        [TestMethod]
        public void FaltaQuantoTempoParaComecar_JaComecou_Test()
        {
            var dtinicio = DateTime.Now.AddHours(-1);
            var dtFim = dtinicio.AddHours(10);

            var periodo = new Periodo
            {
                Inicio = dtinicio,
                Fim = dtFim
            };

            string quantoFalta = periodo.QuantoFaltaParaComecar();

            Assert.AreEqual("Já começou!", quantoFalta);
        }
    }
}
