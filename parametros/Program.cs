// Parâmetros de Referência 

int a = 40; // Obrigatoriamente o valor deve ser assinado previamente ao ser usado como parâmetro de referência
EjetarValor(ref a);


static void EjetarValor(ref int x)
{
    Console.WriteLine($"Valor antes da passagem do método: {x}");
    x += 30;
    Console.WriteLine($"Valor após a passagem do método: {x}");
}




// Parâmetro de saída

int b; // assinatura prévia é facultativo nos parâmetros de saída
EjetarValor2(out b);


static void EjetarValor2(out int x)
{
    Console.WriteLine($"Valor antes da passagem do método não apresenta valor definido (unsigned)");
    x = 45;
    Console.WriteLine($"Valor após a passagem do método: {x}");
}




//Matriz de parâmetros

EjetarValor3(4, 5, 6, 10);


static void EjetarValor3(params int[] Mylist)
{
    foreach (var item in Mylist)
    {
        Console.WriteLine($"Valor obtido da lista: {item}");
    }
}




// Overloading
int c = 1;
int d = 2;
Method.Eject(c); // dentro das possibilidades de métodos, será escolhido o referente aos parâmetros
Method.Eject(c, d); // opção de eject com dois parâmetros, método diferente do primeiro


class Method
{
    public static int Eject(int a)
    {
        Console.WriteLine("Eject Method with 1 argument");
        Console.WriteLine($"Arguments: {a}");
        return 0;
    }


    public static void Eject(int a, int b)
    {
        Console.WriteLine("Eject method with 2 arguments");
        Console.WriteLine($"Arguments: {a} {b}");
        return;
    }
}