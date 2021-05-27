using System;


namespace PeriodosAtras
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataInformada = new DateTime(2021,05,26,10,50,10);
            Data data = new Data(dataInformada);
            ConversorData conversor = new ConversorData();

            int resultado = conversor.TransformarDataEmDiasDecorridos(data);
            int resultado1 = conversor.TransformarDataEmAnosDecorridos(data);
            int resultado2 = conversor.TransformarDataEmMesesDecorridos(data);
            int resultado3 = conversor.TransformarDataEmDiasDecorridos(data);

            Console.WriteLine(resultado);
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado3);
            Console.WriteLine(data.resultado.ToUpper());

            Console.ReadLine();
        }
    }
}
