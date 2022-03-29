
// É possível acessar os valores internos publicos de uma classe static
System.Console.WriteLine(StaticClass.Value);
System.Console.WriteLine(StaticClass.Status);
System.Console.WriteLine(StaticClass.Id);

System.Console.WriteLine(ReadonlyClass.data);



// É possível acessar membros estáticos de classes estáticas 
StaticClass.Eject();


var objeto = new NonStaticClass(203, true, "Error");
objeto.check();
objeto.Status = false;
objeto.check();

objeto.getstatic();


// Classes estáticos não podem ser herdadas
// Não possuem construtor, pois seus campos são sempre os mesmos
// Não instanciam objetos
public static class StaticClass
{
    public static int Value = 101;
    public static bool Status = false;
    public static string Id = "Error";

    public static void Eject()
    {
        System.Console.WriteLine(Value);
        System.Console.WriteLine(Status);
        System.Console.WriteLine(Id);
    }
}




// É possível atribuir campos estáticos em classes não-estáticas
public class NonStaticClass
{
    public static int StaticValue = 100; 
    public int Value;
    public bool Status;
    public string Id;

    public NonStaticClass(int value, bool status, string id)
    {
        this.Value = value;
        this.Status = status;
        this.Id = id;
    }

    public bool check() 
    {
        if (this.Status == StaticClass.Status && this.Id == StaticClass.Id) 
        {
            System.Console.WriteLine("System checked sucessfully");
            System.Console.WriteLine($"Type Value of object: {this.Value}");
            System.Console.WriteLine($"Type Value of Main: {StaticClass.Value}");
            return true;
        }
        else 
            System.Console.WriteLine("Comparison Denied");
            return false;
    }
    public void getstatic() 
    {
        System.Console.WriteLine($"Valor Estático: {StaticValue}");
    }
}

// Readonly pode ser atribuido em seu campo, no método de inicialização
public class ReadonlyClass 
{
    public static readonly int data = 100;
}