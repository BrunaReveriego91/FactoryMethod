namespace FactoryMethod
{
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de calabresa carioca";
            massa = "Massa fina crocante carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Linguiça calabresa");
            ingredientes.Add("Cebola fatiada");
        }

    }
}
