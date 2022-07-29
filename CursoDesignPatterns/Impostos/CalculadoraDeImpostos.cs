namespace CursoDesignPatterns.Impostos
{
    public class CalculadoraDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            double calcular = imposto.Calcula(orcamento);
            Console.WriteLine(calcular);
        }
    }
}
