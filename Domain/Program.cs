
using Domain.Entities;

Console.WriteLine("Hello, World Domain!");

var adm = new Administrador();
Console.WriteLine(adm.GerenciarBiblioteca());
Console.WriteLine(adm.ChamandoObterAdministrador());

var func = new Funcionario();
Console.WriteLine(func.NovoFuncionario());
Console.WriteLine(func.ChamandoAdicionar());
Console.WriteLine(func.ChamandoRemover());

var livro = new Livro();
livro.Titulo = "Titulo";
Console.WriteLine(livro.ObterResumo());

var membro = new Membro();
membro.Nome = "Chico";
Console.WriteLine(membro.EmprestarLivro());
Console.WriteLine(membro.ChamandoObterMembro());