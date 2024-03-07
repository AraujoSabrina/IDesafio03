using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Estudante
    {
        public string Nome { get; private set; }
        public string Matriculas { get; private set; }
        public int Idade { get; private set; }
        public Estudante(string nome,string matricula, int idade)
        {
            this.Matriculas = matricula;
            this.Idade = idade;
            this.Nome = nome;
        }
        
        

    }
    

