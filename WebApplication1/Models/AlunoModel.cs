﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlunoModel
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public DateTime Matricula { get; set; }
        public int Faltas { get; set; }
        public AlunoModel()
        {
            Nome = "ALcassa ";
            Curso = "Desenvolvimento de Sistemas ";
            Faltas = 1;
            Matricula = new DateTime(2023, 2, 17);
        }
        public static AlunoModel CriarAluno()
        {
            var aluno = new AlunoModel();
            aluno.Nome = "Neri";
            return aluno;
        }
        public static List<AlunoModel> CriarLista()
        {
            var lista = new List<AlunoModel>();
            lista.Add(new AlunoModel());
            lista.Add(AlunoModel.CriarAluno());
            return lista;
        }
    }

}
