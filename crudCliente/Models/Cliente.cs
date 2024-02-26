using System.ComponentModel.DataAnnotations;

namespace crudCliente.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

    }
}