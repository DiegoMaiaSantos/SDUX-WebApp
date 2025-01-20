using System.ComponentModel.DataAnnotations;

namespace SDUX_Camed_API_02.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set;}
        //public ICollection<Produto>? ClienteProdutos { get; set; }
    }
}
