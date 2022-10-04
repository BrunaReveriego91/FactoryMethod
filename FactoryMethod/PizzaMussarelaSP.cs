namespace FactoryMethod
{
    //ConcreteProduct
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de mussarela Paulista";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Queijo parmesão");
            ingredientes.Add("Azeitonas verdes");
        }

    }
}
