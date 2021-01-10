using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMediatorPatternInCSharp
{
    public class Candidato
    {
        public string Nome { get; set; }
        private JornalistaIntermediator intermediator;
        
        public Candidato(string Nome, JornalistaIntermediator jornalistaIntermediator)
        {
            this.Nome = Nome;
            this.intermediator = jornalistaIntermediator;
        }
        
        public string Fala(string discurso= null)
        {
            return intermediator.FazDiscurso(this.Nome, discurso);
        }               
    }
}
