using teste;
// Chamando método estático
DerivedClass.drawrectangle();   


// Testando new e override por instância
BaseClass object01 = new DeriClass();

object01.output();
object01.output2();


    public class MainClass
    {
        public virtual void drawline() => System.Console.WriteLine("linha");
        public virtual void drawpoint() => System.Console.WriteLine("point");

        // adição posterior de um método semelhante ao drawrectangle
        public virtual void drawrectangle() => System.Console.WriteLine("Rectangle by Main");
    }



    public class DerivedClass : MainClass
    {
        // a classe derivada cria um novo método ao sistema
        public static new void drawrectangle() => System.Console.WriteLine("Rectangle"); 
        // Sem o modificador new ou override, o compilador gerará um erro e escolherá esse método como substituto
        // métodos estáticos não suportam o modificador override, por algum motivo
        // modificador new, após o modificador está é aceito pelo compilador
        // Em métodos não estático, usa-se o modelo padrão
    }


// Esses modificadores podem ser utilizados em propriedades, indexadores e eventos

// Override --> modificador de preferência
// New --> modificador de substituição (o método escolhido será substituido)

// Virtual --> o modificador virtual permite a implementação de uma nova versão do método
// A criação de uma nova drawrectangle no derivado ocorre sobre permissão do Virtual
// Métodos, por padrão, não são virtuais. A aplicação desse modificador deve ser feita na base

