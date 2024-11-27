namespace BlazingPizza.Data;

public class Pizza
{
    public int PizzaId { get; set; } // Her pizza için benzersiz bir kimlik tanımlayıcı
    public string Name { get; set; } // Pizzanın adı
    public string Description { get; set; } // Pizzanın kısa açıklaması
    public decimal Price { get; set; } // Pizzanın fiyatı
    public bool Vegetarian { get; set; } // Vejetaryen pizza mı, değil mi bilgisi
    public bool Vegan { get; set; } // Vegan pizza mı, değil mi bilgisi
}
