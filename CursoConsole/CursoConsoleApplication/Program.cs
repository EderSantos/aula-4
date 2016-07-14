using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCliente;

namespace CursoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> ListCli = new List<Cliente>();
            ArrayList ListPrd = new ArrayList();
            Cliente cliente = new Cliente();
            Produto produto = new Produto();
            int opcao, operacao;
            do
            {
                Console.Clear();
                Console.WriteLine("1- Cliente");
                Console.WriteLine("2- Produto");
                Console.WriteLine("3- Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("1- Cadastrar Cliente");
                        Console.WriteLine("2- Consultar Cliente");
                        Console.WriteLine("3- Consultar Cliente por Nome");
                        Console.WriteLine("4- Remover Cliente por Nome");
                        break;
                    case 2:
                        Console.WriteLine("1- Cadastrar Produto");
                        Console.WriteLine("2- Consultar Produto");
                        Console.WriteLine("3- Consultar Produto por Nome");
                        Console.WriteLine("4- Remover Produto por Nome");
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Operação Inválida!");
                        break;
                }
                if ((opcao.Equals(1)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Write("Informe o nome:");
                        cliente.nome = Console.ReadLine();
                        Console.Write("Informe  o sexo:");
                        cliente.sexo = Convert.ToChar(Console.ReadLine());
                        Console.Write("Informe  o idade:");
                        cliente.idade = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe  o telefone:");
                        cliente.telefone = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Informe  o endereço:");
                        cliente.endereco = Console.ReadLine();
                        ListCli.Add(cliente);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                    else if ((operacao.Equals(2)))
                    {
                        foreach (Cliente cli in ListCli)
                        {
                            Console.WriteLine("Nome do Cliente: " + cli.nome);
                            Console.WriteLine("Sexo do Cliente: " + cli.sexo);
                            Console.WriteLine("telefone do Cliente: " + cli.telefone);
                            Console.WriteLine("Endereço do Cliente: " + cli.endereco);
                            Console.WriteLine("Idade do Cliente: " + cli.idade);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(3))
                    {
                        Console.WriteLine("Informe nome da pesquisa: ");
                        String nomeAux = Console.ReadLine();
                       
                        foreach (var item in ListCli)
                        {
                            if (item.nome.Equals(nomeAux))
                                Console.WriteLine("Achei!");
                                Console.WriteLine("Nome: "+ item.nome + " Endereço: " + item.endereco);
                                
                            
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(4))
                    {
                        Console.WriteLine("Informe nome da remoção: ");
                        String nomeAux = Console.ReadLine();
                            foreach (var item in ListCli)
                        	{
                                 if (item.nome.Equals(nomeAux))
                                {
                                ListCli.Remove(item);
                                Console.WriteLine("Cliente removido com sucesso!");
                                 }
                                
	                        }
                            Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }
                else if ((opcao.Equals(2)))
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                    if (operacao.Equals(1))
                    {
                        Console.Write("Informe  o codigo:");
                        produto.codigo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe  o descrição:");
                        produto.descricao = Console.ReadLine();
                        Console.Write("Informe  o fabricante:");
                        produto.fabricante = Console.ReadLine();
                        Console.Write("Informe  o valor:");
                        produto.valor = Convert.ToInt32(Console.ReadLine());
                        ListPrd.Add(produto);
                        Console.WriteLine("Produto cadastrado com sucesso!");
                    }
                    else if ((operacao.Equals(2)))
                    {
                        foreach (Produto prd in ListPrd)
                        {
                            Console.WriteLine("Codigo: " + prd.codigo);
                            Console.WriteLine("Descrição: " + prd.descricao);
                            Console.WriteLine("fabricante: " + prd.fabricante);
                            Console.WriteLine("Valor: " + prd.valor);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(3))
                    {
                        Console.WriteLine("Informe codigo do produto: ");
                        String descAux = Console.ReadLine();
                        foreach (Produto item in ListPrd)
                        {
                            if (item.descricao.Equals(descAux))
                                Console.WriteLine("Achei {0}!", item.descricao);
                        }
                        Console.ReadKey();
                    }
                    else if (operacao.Equals(4))
                    {
                        Console.WriteLine("Informe nome da remoção: ");
                        String descAux = Console.ReadLine();
                        foreach (Produto item in ListPrd)
                        {
                            if (item.codigo.Equals(descAux))
                            {
                                ListPrd.Remove(item);
                                Console.WriteLine("Produto removido com sucesso!");
                                break;
                            }
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }
            } while (opcao != 3);
        }
    }
}
