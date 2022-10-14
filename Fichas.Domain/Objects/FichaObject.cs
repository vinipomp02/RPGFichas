using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFichas.Domain.Objects
{
    public class FichaObject
    {
        public Caracteristicas Caracteristicas { get; set; }
        public Atributos Atributos { get; set; }
        public Saude Saude { get; set; }     
        public Defesas Defesas { get; set; }     
        public Pericias Pericias{ get; set; }     
        public List<ArmaObject> Armas { get; set; }
        public string Proeficiencias { get; set; }
        public List<CondicaoObject> Condicao { get; set; }
        public List<InventarioObject> Inventario { get; set; }
        public List<RitualObject> RitualObject { get; set; }
        public List<PoderObject> PoderObject { get; set; }
        public string ImageFile { get; set; }
    }
    public class Caracteristicas
    {
        public string Nome { get; set; }
        public string Origem { get; set; }
        public string Classe { get; set; }
        public int Nex { get; set; }
        public string Patente { get; set; }
        public string Trilha { get; set; }
        public int Prestigio { get; set; }
    }
    public class Atributos
    {
        public int Agi { get; set; }
        public int Int { get; set; }
        public int Vig { get; set; }
        public int Pre { get; set; }
        public int For { get; set; }
    }
    public class Saude
    {
        public int PvTotal { get; set; }
        public int PvAtual { get; set; }
        public int SanTotal { get; set; }
        public int SanAtual { get; set; }
        public int PeTotal { get; set; }
        public int PeAtual { get; set; }
    }
    public class Defesas
    {
        public int DefPassiva { get; set; }
        public int ResAcido { get; set; }
        public int ResBalistico { get; set; }
        public int ResCorte { get; set; }
        public int ResEletrico { get; set; }
        public int ResFogo { get; set; }
        public int ResFrio { get; set; }
        public int ResImpacto { get; set; }
        public int ResMedo { get; set; }
        public int ResMental { get; set; }
        public int ResPerfuracao { get; set; }
        public int ResVeneno { get; set; }
        public int ResSangue { get; set; }
        public int ResMorte { get; set; }
        public int ResEnergia { get; set; }
        public int ResConhecimento { get; set; }
    }
    public class Pericias
    {
        public string  Acrobacia { get; set; }
        public string  Adestramento { get; set; }
        public string  Atletismo{ get; set; }
        public string  Artes { get; set; }
        public string  Atualidades { get; set; }
        public string  Ciencia { get; set; }
        public string  Crime  {get; set; }
        public string  Diplomacia{ get; set; }
        public string  Enganacao{ get; set; }
        public string  Fortitude{ get; set; }
        public string  Furtividade{ get; set; }
        public string  Iniciativa{ get; set; }
        public string  Intimidacao{ get; set; }
        public string  Intuicao{ get; set; }
        public string  Investigacao{ get; set; }
        public string  Luta{ get; set; }
        public string  Medicina{ get; set; }
        public string  Ocultismo{ get; set; }
        public string  Percepcao{ get; set; }
        public string  Pilotagem{ get; set; }
        public string  Pontaria{ get; set; }
        public string  Profissao{ get; set; }
        public string  Reflexos{ get; set; }
        public string  Religiao{ get; set; }
        public string  Sobrevivencia{ get; set; }
        public string  Tatica { get; set; }
        public string  Tecnologia{ get; set; }
        public string  Vontade{ get; set; }
    }
    public class ArmaObject
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Ataque { get; set; }
        public string Alcance { get; set; }
        public string Dano { get; set; }
        public string Critico { get; set; }
        public string Municao { get; set; }
        public string Modificador { get; set; }
        public string Especial { get; set; }
    }
    public class CondicaoObject
    {
        public string NomeCondicao { get; set; }
        public string Tipo { get; set; }
        public string Upgrade { get; set; }

    }
    public class InventarioObject
    {
        public int Qtd { get; set; }
        public string Item { get; set; }
        public string Detalhes { get; set; }
        public int Espacos { get; set; }
        public int Prestigio { get; set; }
       
    }
}
