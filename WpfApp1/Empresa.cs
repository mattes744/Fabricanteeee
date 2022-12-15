using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Empresa : object
    {
        private string nome;
        private Cliente[] vetor = new Cliente[10];
        private int k;
        private List<Cliente> lista = new List<Cliente>();
        public Empresa(string nome)
        {
            this.nome = nome;
        }
        public void Inserir(Cliente c)
        {
            vetor[k] = c;
            k++;
            lista.Add(c);
        }
        public Cliente[] Listar()
        {
            return vetor;
        }
        public List<Cliente> Listar2()
        {
            return lista;
        }
        public override string ToString()
        {
            return $"Nome da Fabricante = {nome}";
        }
    }
}
