// Atribuindo instância
Pagamento pagamento01 = new PagamentoViaTed();
Pagamento pagamento02 = new PagamentoViaBoleto();

pagamento01.Pagar();
pagamento02.Pagar();


// Classe base
public class Pagamento 
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

