namespace AppTerceiro.Models
{
    //Os dois pontos fazem a herança de classe, a classe Juridica irá herdar da classe Pessoa
    public class Juridica: Pessoa
    {
        //Declaraçõa dos (as)
        //Atributo/Propriedade/Variáveis
        public Int64 CNPJ {  get; set; }
        public Int64 IE {  get; set; }
    }
}