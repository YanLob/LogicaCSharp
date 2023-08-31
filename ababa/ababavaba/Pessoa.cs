using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ababavaba
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double peso, altura;

        public Pessoa(string nome, int idade, double peso, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        public void envelhecer(int anoEvelhec)
        {
            
            if (idade > 21)
            {
                crecer(0.05);
            }
            else
            {
                idade += anoEvelhec;
            }
        }

        public void crecer(double crecendo)
        {
            altura += crecendo;
        }

        public void engordar(double engordando)
        {
            peso += engordando;
        }

        public void emagrecer(double emagrecendo)
        {
            peso -= emagrecendo;
        }
    }
}
