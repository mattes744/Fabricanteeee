using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Cliente
    {
        private string nome;
        private string nomedois;
        private double limite = 100;
        public Cliente(string nome, string nomedois, double limite)
        {
            this.nome = nome;
            this.nomedois = nomedois;
            if (limite > 0) this.limite = limite;
        }
        public double GetLimite()
        {
            return limite;
        }
        public override string ToString()
        {
            return $"Nome = {nomedois}      Modelo = {nome}       Valor = {limite}";
        }
    }
}
