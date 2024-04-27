namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected Smartphone(string numero, string modelo, string iMEI, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private string Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama        
        
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}