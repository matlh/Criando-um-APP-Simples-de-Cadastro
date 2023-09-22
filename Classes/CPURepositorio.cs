using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO
{
    public class CPURepositorio : IRepositorio<CPU>
    {
        private List<CPU> ListaCPU = new List<CPU>();
		public void Atualiza(int id, CPU objeto)
		{
			ListaCPU[id] = objeto;
		}

		public void Exclui(int id)
		{
			ListaCPU[id].Excluir();
		}

		public void Insere(CPU objeto)
		{
			ListaCPU.Add(objeto);
		}

		public List<CPU> Lista()
		{
			return ListaCPU;
		}

		public int ProximoId()
		{
			return ListaCPU.Count;
		}

		public CPU RetornaPorId(int id)
		{
			return ListaCPU[id];
		}
    }
}