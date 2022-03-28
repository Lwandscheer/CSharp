namespace teste
{
    public class BaseClass
    {
        public virtual void output() => System.Console.WriteLine("Sucess by base 01");
        public virtual void output2() => System.Console.WriteLine("Sucess by Base 02");
    }

    public class DeriClass : BaseClass
    {
        public override void output() => System.Console.WriteLine("Sucess by Derived 01");
        public new void output2() => System.Console.WriteLine("Sucess by Derived 02");
    }
}