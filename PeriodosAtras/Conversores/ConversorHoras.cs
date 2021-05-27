using System;
using System.Collections.Generic;


namespace PeriodosAtras
{
    public class ConversorHoras : ConversorData
    {
      
        public int TransformarSegundosTotaisEmHorasDecorridas(Temporizador datath)
        {
            
            return (datath.dataAtualTemporizada - datath.dataComTempo).Hours;
        }
        public int TransformarHorasEmMinutosDecorridos(Temporizador datath)
        {
            return (datath.dataAtualTemporizada - datath.dataComTempo).Minutes;
        }
        public int TransformarHorasEmSegundosDecorridos(Temporizador datath)
        {
            return (datath.dataAtualTemporizada - datath.dataComTempo).Seconds;
        }
        public string EscreveNumeroAteDoisDigitosTempo(double valor)
        {
            Dictionary<char, string> unidades, teens, dezenas;
            GerarDictionaryNumerosPorExtenso(out unidades, out teens, out dezenas);

            string montagem = string.Empty;
            string strValor = valor.ToString("00");
            char a = Convert.ToChar(strValor.Substring(0, 1));
            char b = Convert.ToChar(strValor.Substring(1, 1));


            if (a == '1')
                montagem += teens[b] + " ";
            else
            {
                if (dezenas.ContainsKey(a))
                    montagem += dezenas[a] + ((b != '0') ? " e " : " ");

                if (unidades.ContainsKey(b))
                    montagem += unidades[b] + " ";
            }
            return montagem;
        }

    }
}
