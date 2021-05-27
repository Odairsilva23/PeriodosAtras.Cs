using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PeriodosAtras;

namespace PeriodosAtras.Test
{
    [TestClass]
    public class Periodostests
    {
        [TestMethod]
        public void DeveRetornarTotalDiasDecorridos()
        {
            DateTime dataInformada = new DateTime(2020, 05, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual(365, data.tempoTotalDecorridoDias);
        }

        [TestMethod]
        public void DeveRetornarTotalAnosDecorridos()
        {
            DateTime dataInformada = new DateTime(2015, 05, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual(6, data.anosDecorridos);
        }

        [TestMethod]
        public void DeveRetornarTotalMesesDecorridos()
        {
            DateTime dataInformada = new DateTime(2015, 01, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual(4, data.mesesDecorridos);
        }

        [TestMethod]
        public void DeveRetornarTotalSemanasDecorridos()
        {
            DateTime dataInformada = new DateTime(2021, 04, 27);
            Data data = new Data(dataInformada);

            Assert.AreEqual(4, data.semanasDecorridas);
        }

        [TestMethod]
        public void DeveRetornarDiasDecorridos()
        {
            DateTime dataInformada = new DateTime(2021, 05, 20);
            Data data = new Data(dataInformada);

            Assert.AreEqual(6, data.diasDecorridos);
        }

        [TestMethod]
        public void DeveRetornarSeisDiasAtras()
        {
            DateTime dataInformada = new DateTime(2021, 05, 20);
            Data data = new Data(dataInformada);

            Assert.AreEqual("seis dias atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarUmaSemanaAtras()
        {
            DateTime dataInformada = new DateTime(2021, 05, 19);
            Data data = new Data(dataInformada);

            Assert.AreEqual("uma semana atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDoisMesesUmaSemanaAtras()
        {
            DateTime dataInformada = new DateTime(2021, 03, 20);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dois mêses e uma semana atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDoisMesesDoisDiasAtras()
        {
            DateTime dataInformada = new DateTime(2021, 03, 25);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dois mêses e dois dias atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDezAnosAtras()
        {
            DateTime dataInformada = new DateTime(2011, 05, 29);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dez anos atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDataInvalida()
        {
            DateTime dataInformada = new DateTime(2021, 05, 27);
            Data data = new Data(dataInformada);

            Assert.AreEqual("Data no Futuro", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarQuatroSemanasAtras()
        {
            DateTime dataInformada = new DateTime(2021, 04, 28);
            Data data = new Data(dataInformada);

            Assert.AreEqual("quatro semanas atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarUmMesAtras()
        {
            DateTime dataInformada = new DateTime(2021, 04, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual("um mês atrás", data.resultado);
        }
        [TestMethod]
        public void DeveRetornarUmMesduasSemanasEtresDiasAtras()
        {
            DateTime dataInformada = new DateTime(2021, 04, 9);
            Data data = new Data(dataInformada);

            Assert.AreEqual("um mês e duas semanas e três dias atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDezAnoseTRESDIAS()
        {
            DateTime dataInformada = new DateTime(2011, 05, 26);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dez anos e três dias atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDezAnoseTRESsemanas()
        {
            DateTime dataInformada = new DateTime(2011, 05, 8);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dez anos e três semanas atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornarDezAnoseDoisMesesTRESsemanasEcincodias()
        {
            DateTime dataInformada = new DateTime(2011, 03, 4);
            Data data = new Data(dataInformada);

            Assert.AreEqual("dez anos e dois mêses e três semanas e cinco dias atrás", data.resultado);
        }

        [TestMethod]
        public void DeveRetornar23SegundosAtras()
        {
            DateTime dataComTempo = new DateTime(2021, 05, 26, 23, 50, 02);
            Temporizador datath = new Temporizador(dataComTempo);

            Assert.AreEqual("vinte e três segundos atrás", datath.resultadoTempo);
        }

        [TestMethod]
        public void DeveRetornarCincoMinutosAtras()
        {
            DateTime dataComTempo = new DateTime(2021, 05, 26, 23, 45, 25);
            Temporizador datath = new Temporizador(dataComTempo);

            Assert.AreEqual("cinco minutos atrás", datath.resultadoTempo);
        }

        [TestMethod]
        public void DeveRetornarUmaHoraAtras()
        {
            DateTime dataComTempo = new DateTime(2021, 05, 26, 22, 50, 25);
            Temporizador datath = new Temporizador(dataComTempo);

            Assert.AreEqual("uma hora atrás", datath.resultadoTempo);
        }
        [TestMethod]
        public void DeveRetornarUmaHoraEvinteMinutosAtras()
        {
            DateTime dataComTempo = new DateTime(2021, 05, 26, 22, 30, 25);
            Temporizador datath = new Temporizador(dataComTempo);

            Assert.AreEqual("uma hora e vinte minutos atrás", datath.resultadoTempo);
        }
        [TestMethod]
        public void DeveRetornarUmaHoraEvinteMinutosEdoisSegudosAtras()
        {
            DateTime dataComTempo = new DateTime(2021, 05, 26, 22, 30, 23);
            Temporizador datath = new Temporizador(dataComTempo);

            Assert.AreEqual("uma hora e vinte minutos e dois segundos atrás", datath.resultadoTempo);
        }
        [TestMethod]
        public void DeveRetornarSeisHoraE12MinutosEvinteSegudosAtras()
        {
            DateTime dataComTempo = new DateTime(2021, 05, 26, 17, 38, 05);
            Temporizador datath = new Temporizador(dataComTempo);

            Assert.AreEqual("seis horas e doze minutos e vinte segundos atrás", datath.resultadoTempo);
        }
    }
}
