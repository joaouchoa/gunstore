using gunstore.Enumeraveis;

namespace gunstore.Classes
{
    public class Melee : Weapon
    {
        public string? Modelo { get; set; }
        public string? Fabricante { get; set; }
        public EType Tipo {get; set;}
        

        public Melee(string modelo, string fabrincate, EType tipo)
        {
            Modelo = modelo;
            Fabricante = fabrincate;
            Tipo = tipo;
            Active = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Modelo: " + this.Modelo + Environment.NewLine;
            retorno += "Fabricante: " + this.Fabricante + Environment.NewLine;
            retorno += "Tipo: " + this.Tipo + Environment.NewLine;
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