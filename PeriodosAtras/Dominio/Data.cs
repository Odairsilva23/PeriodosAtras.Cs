using System;


namespace PeriodosAtras
{
    public class Data
    {
        #region Propriedades
        readonly ConversorData conversorData = new ConversorData();
        public DateTime dataInformada;
        public  DateTime dataAtual = new DateTime(2021,05,26);
        
        public int tempoTotalDecorridoDias;
        public int anosDecorridos, restoAnosDecorridos;
        public int mesesDecorridos, restoMesesDecorridos;
        public int semanasDecorridas, restoSemanasDecorridas;
        public int diasDecorridos;

        public string resultado = null;
        #endregion

        public Data(DateTime d)
        {
            dataInformada = d;
           
            if (dataInformada > dataAtual)
            {
                resultado = "Data no Futuro";
            }
            else 
            {
                SeparadorDatas();
                EscrevedorDatas();
               
            } 
            
        }
       
        public void EscrevedorDatas()
        {
            MetododeAnoEAnos();
            MetododemesEMeses();
            MetododeSemaeSemanas();
            MetododeDiaeDias();
        }
        private void SeparadorDatas()
        {
            tempoTotalDecorridoDias = conversorData.TransformarDataEmDiasTotaisDecorridos(this);
            anosDecorridos = conversorData.TransformarDataEmAnosDecorridos(this);
            mesesDecorridos = conversorData.TransformarDataEmMesesDecorridos(this);
            semanasDecorridas = conversorData.TransformarDataEmSemanasDecorridos(this);
            diasDecorridos = conversorData.TransformarDataEmDiasDecorridos(this);
        }

        private void MetododeDiaeDias()
        {
            resultado += conversorData.EscreveNumeroAteDoisDigitos(diasDecorridos);
            if (diasDecorridos != 0)
            {
                if (diasDecorridos == 1)
                    resultado += "dia ";
                else
                    resultado += "dias ";
            }
            if (resultado != null && dataInformada != dataAtual)
                resultado += "atrás";
        }

        private void MetododeSemaeSemanas()
        {
            resultado += conversorData.EscreveNumeroAteDoisDigitos(semanasDecorridas);
            if (semanasDecorridas != 0)
            {
                if (semanasDecorridas == 1)
                {
                    resultado += "semana ";
                    resultado = resultado.Replace("um semana", "uma semana");
                }
                else if (semanasDecorridas == 2)
                {
                    resultado += "semanas ";
                    resultado = resultado.Replace("dois semanas", "duas semanas");
                }
                else
                    resultado += "semanas ";

                if (diasDecorridos != 0)
                    resultado += "e ";
            }
        }

        private void MetododemesEMeses()
        {
            resultado += conversorData.EscreveNumeroAteDoisDigitos(mesesDecorridos);
            if (mesesDecorridos != 0)
            {
                if (mesesDecorridos == 1)
                    resultado += "mês ";
                else
                    resultado += "mêses ";

                if (semanasDecorridas != 0 || diasDecorridos != 0)
                    resultado += "e ";
            }
        }

        private void MetododeAnoEAnos()
        {
            resultado = conversorData.EscreveNumeroAteDoisDigitos(anosDecorridos);
            if (anosDecorridos != 0)
            {
                if (anosDecorridos == 1)
                    resultado += "ano ";
                else
                    resultado += "anos ";

                if (mesesDecorridos != 0 || semanasDecorridas != 0 || diasDecorridos != 0)
                    resultado += "e ";
            }
        }
    }
}
