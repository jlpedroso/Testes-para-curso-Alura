using TesteParaCursos;

// Projeto para fazer testes nos cursos da Alura

List<Dictionary<string, string>> dados = new()
{
    new Dictionary<string, string>
    {
        {"Nome","Alice" },
        {"Idade","38" },
        {"Cidade" , "Salvador" }
    },
    new Dictionary<string, string>
    {
        {"Nome","Jose Luis" },
        {"Idade","47" },
        {"Cidade" , "Osasco" }
    },
    new Dictionary<string, string>
    {
        {"Nome","Priscila" },
        {"Idade","45" },
        {"Cidade" , "São Paulo" }
    }
};

Curso1934 curso1934 = new Curso1934();

curso1934.GeraRelatorios(dados);



