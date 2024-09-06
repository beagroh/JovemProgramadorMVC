﻿using JovemProgramadorMVC.Models;

namespace JovemProgramadorMVC.Data.Repositorio
{ 
public class AlunoRepositorio : IAlunoRepositorio
{

    private readonly BancoContexto _bancoContexto;

        public int Id { get; private set; }

        public AlunoRepositorio(BancoContexto bancoContexto)
    {
        _bancoContexto = bancoContexto;
    }

    public List<Aluno> BuscarAlunos()
    {
        return _bancoContexto.Aluno.ToList();
    }

        public void InserirAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }

        public Aluno BuscarId(int id)
        {
            return _bancoContexto.Aluno.FirstOrDefault(x => x.Id == id);
        }

        public void EditarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Update(aluno);
            _bancoContexto.SaveChanges();
        }
    }

}
