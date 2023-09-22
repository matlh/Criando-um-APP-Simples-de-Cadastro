using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace DIO
{
    public class CPU : EntidadeBase
    {
		private string Modelo { get; set; }
		private string NucleoThread { get; set; }
		private string TDP { get; set; }
        private string ClockBase { get; set; }
        private string ClockBoost { get; set; }
        private bool Excluido {get; set;}

        // Métodos
		public CPU (int id, string Modelo, string NucleoThread, string TDP, string ClockBase, string ClockBoost)
		{
			this.Id = id;
			this.Modelo = Modelo;
			this.NucleoThread = NucleoThread;
			this.TDP = TDP;
            this.ClockBase = ClockBase;
            this.ClockBoost = ClockBoost;
            this.Excluido = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Modelo: " + this.Modelo + Environment.NewLine;
            retorno += "Núcloes/Threads: " + this.NucleoThread + Environment.NewLine;
            retorno += "TDP: " + this.TDP + Environment.NewLine;
            retorno += "ClockBase: " + this.ClockBase + Environment.NewLine;
            retorno += "ClockBoost: " + this.ClockBoost + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaModelo()
		{
			return this.Modelo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}