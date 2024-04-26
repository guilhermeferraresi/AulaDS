namespace AppTerceiro.Models
{
    public class Pessoa
    {
        //get: Método de leitura ( ele irá pegar o valor atribuído)
        //set: Método de gravação (ele atribui o valor)
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Sexo {  get; set; }
       
        public Pessoa selectPessoa()
        {
            Pessoa ObjPessoa = new Pessoa();
            return ObjPessoa;
        }
    }
}
