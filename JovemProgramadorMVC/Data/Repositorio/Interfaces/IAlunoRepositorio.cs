﻿using JovemProgramadorMVC.Models;

public interface IAlunoRepositorio
{
    List<Aluno> BuscarAlunos();

    void InserirAluno(Aluno aluno);
}
