using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMediatorPatternInCSharp
{
    public class JornalistaIntermediator
    {

        public string Nome { get; set; }
        private int SegundosParaDiscurso { get; set; }
        private DateTime InicioDiscurso { get; set; }
        public JornalistaIntermediator(string Nome, int segundosParaDiscurso)
        {
            this.Nome = Nome;
            this.SegundosParaDiscurso = segundosParaDiscurso;
        }

        public string FazDiscurso(string NomeCandidato, string discursoCandidato = null)
        {
            IniciaCronometro();
            if (CronometroFinalizado())
            {
                return $"[{this.Nome}] As {DateTime.Now.ToString()} Como previsto para este discurso {this.SegundosParaDiscurso } segundos. Discurso finalizado, Obrigado a todos espectadores";
            }
            else if (String.IsNullOrEmpty(discursoCandidato))
            {
                return $"[{this.Nome} ] O candidato {NomeCandidato} decide não falar nesta rodada";
            }
            else
            {
                return $"[{this.Nome}] As {DateTime.Now.ToString()} o candidato {NomeCandidato} pega a palavra com o discurso: - {discursoCandidato}";
            }
        }
        private void IniciaCronometro()
        {
            if (this.InicioDiscurso == DateTime.MinValue)
                this.InicioDiscurso = DateTime.Now;
        }
        private bool CronometroFinalizado()
        {
            var tempoAgora = DateTime.Now;
            var tempoDecorrido = tempoAgora.Subtract(this.InicioDiscurso).TotalSeconds;          

            return tempoDecorrido >= this.SegundosParaDiscurso;
        }

    }
}
