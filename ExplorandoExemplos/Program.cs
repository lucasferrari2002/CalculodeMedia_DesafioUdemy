using ExplorandoExemplos.Models;

Pessoa p1 = new Pessoa(nome: "Joao", sobrenome: "Miguel");
Pessoa p2 = new Pessoa(nome: "Lucas", sobrenome: "Ferrari");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
cursoDeIngles.RemoverAluno(p1);



