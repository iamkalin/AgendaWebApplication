using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo 'NOME' é obrigatório")]
        [MaxLength(50, ErrorMessage = "O número máximo de caracteres é 50 ")]
        public string Nome{get;set;}
       
        [MaxLength(20, ErrorMessage = "O número máximo de caracteres é 20")]
        [Phone(ErrorMessage = "Digite um telefone valido")]
        public string Telefone{get;set;}
        [MaxLength(50, ErrorMessage =" O número máximo de caracteres é  50 ")]
        [EmailAddress(ErrorMessage = "Digite um email valido")]
        public string Email{ get; set; }
    }
}
