namespace BlazingPizza.Data;

/* public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        // Burada veri erişim teknolojiniz (örneğin, Entity Framework, SQL sorguları vb.) kullanılacak
        // Burada veri erişim teknolojiniz kullanılacak
        return Task.FromResult(new Pizza[0]); // Boş bir Pizza dizisi döndürülüyor


        
    }

    
}
*/

 public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            var pizzas = new Pizza[]
            {
                new Pizza { Name = "Margherita", Description = "Classic pizza with cheese and tomato", Vegetarian = true, Vegan = false, Price = 9.99M },
                new Pizza { Name = "Pepperoni", Description = "Pepperoni with mozzarella", Vegetarian = false, Vegan = false, Price = 12.99M }
            };

            return Task.FromResult(pizzas);
        }
    }

