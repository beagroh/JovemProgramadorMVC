using JovemProgramadorMVC.Models;

    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();

        void InserirAluno(Aluno aluno);

        Aluno BuscarId(int id);

        void EditarAluno(Aluno aluno);
    }
