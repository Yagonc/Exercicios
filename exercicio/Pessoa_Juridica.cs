namespace Exercicio
{
    class Pessoa_Juridica : Clientes
    {
       public string CNPJ {get; set;}
       public string IE {get; set;}
       public override void Pagar_Imposto(float v)
       {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
       }
    }
}