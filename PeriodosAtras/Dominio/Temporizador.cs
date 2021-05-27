using System;


namespace PeriodosAtras
{
    public class Temporizador 
    {
        #region Propriedades

        readonly ConversorHoras conversorHoras = new ConversorHoras();
        public DateTime dataComTempo;
        public DateTime dataAtualTemporizada = new DateTime(2021, 05, 26, 23, 50, 25);

        public int totalSegundos;
        public int horasDecorridas, restoHorasDecorridas;
        public int minutosDecorridos, restoMinutosDecorridos;
        public int segundosDecorridos;

        public string resultadoTempo = null;
        #endregion

        public Temporizador (DateTime th)
        {
            dataComTempo = th;

            if (dataComTempo > dataAtualTemporizada)
            {
                resultadoTempo = "Data no Futuro";
            }
            else
            {
                SeparadorDatasComTempo();
                EscrevedorDatasComTempo();
            }
        }
        private void SeparadorDatasComTempo()
        {
            
            horasDecorridas = conversorHoras.TransformarSegundosTotaisEmHorasDecorridas(this);
            minutosDecorridos = conversorHoras.TransformarHorasEmMinutosDecorridos(this);
            segundosDecorridos = conversorHoras.TransformarHorasEmSegundosDecorridos(this);
        }

        public void EscrevedorDatasComTempo()
        {
            MetodoHoraeHoras();

            MetodoMinutoeMinutos();

            MetodoSegundoEsegunddos();
        }

        private void MetodoSegundoEsegunddos()
        {
            resultadoTempo += conversorHoras.EscreveNumeroAteDoisDigitosTempo(segundosDecorridos);
            if (segundosDecorridos != 0)
            {
                if (segundosDecorridos == 1)
                    resultadoTempo += "segundo ";
                else
                    resultadoTempo += "segundos ";
            }
            if (resultadoTempo != null && dataComTempo != dataAtualTemporizada)
                resultadoTempo += "atrás";
        }

        private void MetodoMinutoeMinutos()
        {
            resultadoTempo += conversorHoras.EscreveNumeroAteDoisDigitosTempo(minutosDecorridos);
            if (minutosDecorridos != 0)
            {
                if (minutosDecorridos == 1)
                    resultadoTempo += "minuto ";
                else
                    resultadoTempo += "minutos ";

                if (segundosDecorridos != 0)
                    resultadoTempo += "e ";
            }
        }

        private void MetodoHoraeHoras()
        {
            resultadoTempo = conversorHoras.EscreveNumeroAteDoisDigitosTempo(horasDecorridas);
            if (horasDecorridas != 0)
            {
                if (horasDecorridas == 1)
                {
                    resultadoTempo += "hora ";
                    resultadoTempo = resultadoTempo.Replace("um hora", "uma hora");
                }
                else
                {
                    resultadoTempo += "horas ";
                    resultadoTempo = resultadoTempo.Replace("dois hora", "duas hora");
                }

                if (minutosDecorridos != 0 || segundosDecorridos != 0)
                    resultadoTempo += "e ";
            }
        }
    }
}
