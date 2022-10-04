namespace FactoryMethod
{
    public class PizzaCalabresaSP:Pizza
    {
        public PizzaCalabresaSP()
        {
            Nome = "Pizza de calabresa Paulista";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Linguiça calabresa");
            ingredientes.Add("Cebola fatiada");
        }
      
    }
}
