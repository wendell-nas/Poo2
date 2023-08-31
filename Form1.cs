using Dominio.Entidades;
using iProject.Modulos.Financeiro;
namespace Poo2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var id = 1;
            var nome = "WN METEFICHA";
            var cpf = "1234566789";
            var dataNascimento = DateTime.Now;
            var setor = "Produçao";

            var cliente = new Cliente(id,nome,cpf,dataNascimento);
            cliente.Telefone = "27999863991";
            cliente.Email = "wendellnascarneiro16@gmail.com";

            var Funcionario = new Funcionario(id,nome,cpf,dataNascimento,setor);
            Funcionario.Cargo = "Operador";

            var aluno = new Aluno(id, nome, cpf, dataNascimento);
            aluno.Telefone = "27999863991";
            aluno.Email = "wendellnascarneiro16@gmail.com";
            aluno.Curso = "Desenvolvedor de Sistemas";
            aluno.Turno = "Noturno";
        }
    }
}