namespace Vets.Models
{
    public class Donos
    {
        //Macro 'prop' para escrever já a pre-definição

        public Donos()
        {

            //isto é uma instância, que é para completar a parte de manipulação de dados
            ListaAnimais = new HashSet<Animais>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }

        public string Sexo { get; set; }


        //Facil em termos de manipulação de dados, mas necessito de um construtor
        public ICollection<Animais> ListaAnimais { get; set; }


    }
}