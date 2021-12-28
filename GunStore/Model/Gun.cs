using GunStore.Enumerable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunStore.Model
{
    public class Gun : Weapon
    {
        private string? Fabricante { get; set; }
        private int Capacidade { get; set; }
        private string? Modelo { get; set; }
        private ECalibre Calibre { get; set; }
        private string? NumeroDeSerie { get; set; }

        public Gun(string fabricante, int id, ECalibre calibre, int capacidade, string modelo, string numeroDeSerie)
        {
            this.id = id;
            Calibre = calibre;
            Capacidade = capacidade;
            Modelo = modelo;
            NumeroDeSerie = numeroDeSerie;
            Fabricante = fabricante;
            this.Active = true;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Modelo: " + this.Modelo + Environment.NewLine;
            retorno += "Calibre: " + this.Calibre + Environment.NewLine;
            retorno += "Capacidade: " + this.Capacidade + Environment.NewLine;
            retorno += "Fabricante: " + this.Fabricante + Environment.NewLine;
            retorno += "Numero de Série: " + this.NumeroDeSerie + Environment.NewLine;
            retorno += "Ativo: " + this.Active + Environment.NewLine;

            return retorno;
        }

        public string retornaModelo()
        {
            return this.Modelo;
        }

        public int retornaId()
        {
            return this.id;
        }
    }
}
