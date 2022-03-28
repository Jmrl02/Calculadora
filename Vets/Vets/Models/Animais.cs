using System.ComponentModel.DataAnnotations.Schema;

namespace Vets.Models
{
    public class Animais
    {
        //Macro 'prop' para escrever já a pre-definição

        public Animais()
        {
            ListaConsultas = new HashSet<Consultas>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Raca { get; set; }

        public string Especie { get; set; }

        public DateTime DataNascimento { get; set; }

        public double Peso { get; set; }

        public string Fotografia { get; set; }

        //Assim cria-se uma chave forasteira (caso a relação precise de uma)
        //Os '[]' são anotadores
        [ForeignKey(nameof(Dono))]  //  ou [ForeignKey("Dono")] é o mesmo, com a diferença que se me enganar a escrever num lado, o erro aparece quando faço essa alteração, e o outro, só aparece o erro quando corro o programa
        public int DonoFk { get; set; }
        public Donos Dono { get; set; }

        public ICollection<Consultas> ListaConsultas { get; set; }

    }
}