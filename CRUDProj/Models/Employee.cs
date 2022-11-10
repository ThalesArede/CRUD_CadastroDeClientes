// Classe do empregado
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDProj.Models
{
    public class Employee // Criar entidades, cada entidade significa uma tabela do banco
    { // Criação de um funcionário

        [Key]

        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")] // Definindo o tamanho da coluna no banco
        [DisplayName("Nome")] // Passamos os nomes para PTBR exibidos em tela
        [Required(ErrorMessage = "Campo obrigatório")] //Obriga a preencher o nome antes de salvar e definimos a mensagem de erro     
        public string FullName { get; set; } // Nome do funcionário

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Matrícula")] // Passamos os nomes para PTBR 
        public string EmpCode { get; set; } // Número da matrícula

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Cargo")] // Passamos os nomes para PTBR
        public string Position { get; set; } // Cargo

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Localização")] // Passamos os nomes para PTBR
        public string OfficeLocation { get; set; }
    }
}
