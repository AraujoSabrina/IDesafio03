using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
public class StudentRegistry
{
        List<Estudante> estudante = new List<Estudante>();
    
        public void AdionarEstudante(Estudante aluno)
        {
            estudante.Add(aluno);  
        }
        public void RemoverEstudante(Estudante matricula)
        {

            estudante.Remove(matricula);
           /*for(int i = 0;i< estudante.Count; i++) { 
                if (matricula.Equals(estudante[i].Matriculas))
                {
                    estudante = null;
                }
            }*/
        }
        public void Exibir()
        {
            for (int i = 0; i < estudante.Count; i++)
            {
                Console.WriteLine(estudante);
            }
        }
             
   }
