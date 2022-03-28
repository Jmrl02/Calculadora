using System.ComponentModel.DataAnnotations.Schema;

namespace Vets.Models
{
    public class Consultas
    {
        //Macro 'prop' para escrever já a pre-definição

        public int Id { get; set; }
        public DateTime Data { get; set; }

        public string Observacoes { get; set; }

        public decimal ValorConsulta { get; set; }


        [ForeignKey(nameof(Animal))]
        public int AnimalFk { get; set; }

        public Animais Animal { get; set; }

        [ForeignKey(nameof(Veterinario))]
        public int VeterinarioFk { get; set; }

        public Veterinarios Veterinario { get; set; }
    }
}