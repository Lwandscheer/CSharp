// Atribuindo instância
Pagamento pagamento01 = new PagamentoViaTed();
Pagamento pagamento02 = new PagamentoViaBoleto();

// Não é possível fazer uma instância de uma classe abstrata, pois ela por si só não apresenta funcionalidades práticas
// Pagamento pagamento = new Pagamento(); --> irá gerar um erro

pagamento01.Pagar();
pagamento02.Pagar();


// Classe base
public abstract class Pagamento 
{
    public double Valor {get; set;}
    public DateTime Vencimento {get; set;}

    public virtual void Pagar() {}
}

// As duas classes que herdaram os campos da base usam os modificadores override para definir suas próprias definições
public class PagamentoViaBoleto : Pagamento
{
    public override void Pagar() => System.Console.WriteLine("Pagamento por boleto");
}

public class PagamentoViaTed : Pagamento
{
    public override void Pagar() => System.Console.WriteLine("Pagamento via Ted");
}

