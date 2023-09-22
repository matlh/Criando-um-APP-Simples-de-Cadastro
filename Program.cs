using System;
using System.Runtime.CompilerServices;

namespace DIO
{
    class Program
    {
		static CPURepositorio repositorio = new CPURepositorio();
        public static void Main (string[] args)
        {
            string OpcaoUsuario = ObterOpcaoUsuario();

            while (true)
            {
                switch (OpcaoUsuario)
				{
					case "1":
						ListarCPU();
						break;
					case "2":
						InserirCPU();
						break;
					case "3":
						AtualizarCPU();
						break;
					case "4":
						ExcluirCPU();
						break;
					case "5":
						VisualizarCPU();
						break;
					case "C":
						Console.Clear();
						break;
					case "X":
						break;
					default:
						Console.WriteLine("Digite uma opção válida.");
						break;
				}

				if (OpcaoUsuario == "X")
				break;

                OpcaoUsuario = ObterOpcaoUsuario();

				if (OpcaoUsuario == "X")
				break;
            }
        }

             private static string ObterOpcaoUsuario()
		     {
		    	Console.WriteLine();
		    	Console.WriteLine("DIO CPUs a seu dispor!!!");
		    	Console.WriteLine("Informe a opção desejada:");

		    	Console.WriteLine("1- Listar CPU");
		    	Console.WriteLine("2- Inserir nova CPU");
		    	Console.WriteLine("3- Atualizar CPU");
		    	Console.WriteLine("4- Excluir CPU");
		    	Console.WriteLine("5- Visualizar CPU");
		    	Console.WriteLine("C- Limpar Tela");
		    	Console.WriteLine("X- Sair");
		    	Console.WriteLine();

		    	string OpcaoUsuario = Console.ReadLine().ToUpper();
		    	Console.WriteLine();
		    	return OpcaoUsuario;
		     }

              private static void ListarCPU()
		      {
		    	    Console.WriteLine("Listar CPUs");

		    	    var lista = repositorio.Lista();

		    	    if (lista.Count == 0)
		    	    {
		    		    Console.WriteLine("Nenhuma CPU cadastrada.");
		    		    return;
		    	    }

		    	    foreach (var CPU in lista)
		    	    {
                        var excluido = CPU.retornaExcluido();
                
		    		    Console.WriteLine("#ID {0}: - {1} {2}", CPU.retornaId(), CPU.retornaModelo(), (excluido ? "*Excluído*" : ""));
		    	    }
                }

                private static void InserirCPU()
		        {
                    Console.WriteLine("Inserir nova CPU");

                    foreach (int i in Enum.GetValues(typeof(Fabricante)))
			        {
				        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Fabricante), i));
			        }

                    
			        Console.Write("Digite um fabicante de CPU entre as opções acima: ");
			        
					int EntradaFabricante = int.Parse(Console.ReadLine());

                    while (true)
                    {

                        if (EntradaFabricante == 1)
                        {
			                foreach (int i in Enum.GetValues(typeof(AMDGeracao)))
			                {   
				            	Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(AMDGeracao), i));
			                }

			                Console.Write("Digite a geração entre as opções acima: ");
			                int entradaGeracao = int.Parse(Console.ReadLine());
							break;
                        }

                        else if (EntradaFabricante == 2)
                        {
			                foreach (int i in Enum.GetValues(typeof(IntelGeracao)))
			                {
				            	Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(IntelGeracao), i));
			                }

			                Console.Write("Digite a geração entre as opções acima: ");
			                int entradaGeracao = int.Parse(Console.ReadLine());
							break;
                        }

                        else
                        Console.WriteLine("Digite um valor válido");

					}  

			        Console.Write("Digite o modelo do processador: ");
			        string EntradaModelo = Console.ReadLine();

			        Console.Write("Digite o número de núcleos e threads (núcleos\threads): ");
			        string EntradaNucleoThread = Console.ReadLine();

			        Console.Write("Digite o TDP: ");
			        string EntradaTDP = Console.ReadLine();

                    Console.Write("Digite o clock base: ");
			        string EntradaClockBase = Console.ReadLine();

                    Console.Write("Digite o clock boost: ");
			        string EntradaClockboost = Console.ReadLine();

			        CPU novaCPU = new CPU (id: repositorio.ProximoId(),
                                    
										                                    Modelo: EntradaModelo,
										                                    NucleoThread: EntradaNucleoThread,
                                                                            TDP: EntradaTDP,
                                                                            ClockBase: EntradaClockBase,
                                                                            ClockBoost: EntradaClockboost);

			        repositorio.Insere(novaCPU);
		        }

				 private static void AtualizarCPU()
				{
					Console.Write("Digite o id da CPU: ");
					int indiceCPU = int.Parse(Console.ReadLine());

					foreach (int i in Enum.GetValues(typeof(Fabricante)))
			        {
				        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Fabricante), i));
			        }

                    
			        Console.Write("Digite um fabicante de CPU entre as opções acima: ");
			        int EntradaFabricante = int.Parse(Console.ReadLine());

                    while(true)
                    {
                        if (EntradaFabricante == 1)
                        {
			                foreach (int i in Enum.GetValues(typeof(AMDGeracao)))
			                {   
				            	Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(AMDGeracao), i));
			                }

			                Console.Write("Digite a geração entre as opções acima: ");
			                int entradaGeracao = int.Parse(Console.ReadLine());
							break;
                        }

                        else if (EntradaFabricante == 2)
                        {
			                foreach (int i in Enum.GetValues(typeof(IntelGeracao)))
			                {
				            	Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(IntelGeracao), i));
			                }

			                Console.Write("Digite a geração entre as opções acima: ");
			                int entradaGeracao = int.Parse(Console.ReadLine());
							break;
                        }

                        else
                        Console.WriteLine("Digite um valor válido");
					}  

			        Console.Write("Digite o modelo do processador: ");
			        string EntradaModelo = Console.ReadLine();

			        Console.Write("Digite o número de núcleos e threads (núcleos\threads): ");
			        string EntradaNucleoThread = Console.ReadLine();

			        Console.Write("Digite o TDP: ");
			        string EntradaTDP = Console.ReadLine();

                    Console.Write("Digite o clock base: ");
			        string EntradaClockBase = Console.ReadLine();

                    Console.Write("Digite o clock boost: ");
			        string EntradaClockboost = Console.ReadLine();

					CPU atualizaCPU = new CPU (id: repositorio.ProximoId(),
                                    
										                                    Modelo: EntradaModelo,
										                                    NucleoThread: EntradaNucleoThread,
                                                                            TDP: EntradaTDP,
                                                                            ClockBase: EntradaClockBase,
                                                                            ClockBoost: EntradaClockboost);

			        repositorio.Atualiza(indiceCPU, atualizaCPU);
				}

				private static void ExcluirCPU()
				{
					Console.Write("Digite o id da CPU: ");
					int indiceCPU = int.Parse(Console.ReadLine());

					repositorio.Exclui(indiceCPU);
				}

				private static void VisualizarCPU()
				{
					Console.Write("Digite o id da CPU: ");
					int indiceCPU = int.Parse(Console.ReadLine());

					var CPU = repositorio.RetornaPorId(indiceCPU);

					Console.WriteLine(CPU);
				}			
    }
}
