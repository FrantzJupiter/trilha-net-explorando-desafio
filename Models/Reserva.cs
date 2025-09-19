namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {


            try
            {
                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            if (Hospedes != null)
            {
                return Hospedes.Count;
            }

            return 0;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = 0;

            if (Suite != null)
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }

            if (DiasReservados >= 10)
            {
                valor -= valor * 0.1M;
            }




            return valor;
        }
    }
}