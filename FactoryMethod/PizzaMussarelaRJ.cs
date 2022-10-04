namespace FactoryMethod
{
    //ConcreteProduct
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela carioca";
            massa = "Massa fina crocante carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmesão");
            ingredientes.Add("Azeitonas verdes");
        }

    }
}
