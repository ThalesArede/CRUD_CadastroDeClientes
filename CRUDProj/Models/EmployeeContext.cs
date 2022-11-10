// Classe criada para conexão com o Banco de Dados
using Microsoft.EntityFrameworkCore;

namespace CRUDProj.Models
{
    public class EmployeeContext : DbContext // DbContext para Herdar
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        // Chamando no DbSet a classe que criamos pois é a que vai ser consumida
        public DbSet<Employee> Employees { get; set; }
    }
}
