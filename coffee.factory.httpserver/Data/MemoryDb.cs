public record Coffee
{
    public int Id { get; set; }
    public string ? Name { get; set; }
    public double Price { get; set; }
}

/*
     * 
     *  Caffè Americano	Short	5Cal	$2.65
        Caffè Americano	Tall	10Cal	$2.95
        Caffè Americano	Grande	15Cal	$3.45
        Caffè Americano	Venti	20Cal	$3.65
        Cappuccino	Short	70Cal	$3.35
        Cappuccino	Tall	100Cal	$3.45
        Cappuccino	Grande	140Cal	$4.25
        Cappuccino	Venti	200Cal	$4.75
        Espresso	Solo	5Cal	$2.45
        Espresso	Doppio	10Cal	$2.65
        Espresso	Triple	15Cal	$2.95
        Espresso	Quad	20Cal	$3.25
        Espresso Con Panna	Solo	30Cal	$2.55
        Espresso Con Panna	Doppio	35Cal	$2.75
        Espresso Con Panna	Triple	40Cal	$3.05
        Espresso Con Panna	Quad	45Cal	$3.35

    This catalog was based on https://www.fastfoodprice.com/menu/starbucks-prices/
     */
/// <summary>
///THIS IS A DEBUG CLASS - Don't use it in production 
///
/// The Coffee Price 
/// 
/// </summary>
internal class MemoryCoffeeFactoryDb 
{
    private List<Coffee> _coffees = new List<Coffee>()
    {
        new Coffee {Id = 1, Name = "Caffè Americano	Short	5Cal	", Price = 2.65},
        new Coffee {Id = 2, Name = "Caffè Americano	Tall	10Cal	", Price = 2.95},
        new Coffee {Id = 3, Name = "Caffè Americano	Grande	15Cal	", Price = 3.45},
        new Coffee {Id = 4, Name = "Caffè Americano	Venti	20Cal	", Price = 3.65},
        new Coffee {Id = 5, Name = "Cappuccino	Short	70Cal	", Price = 3.35},
        new Coffee {Id = 6, Name = "Cappuccino	Tall	100Cal	", Price = 3.45},
        new Coffee {Id = 7, Name = "Cappuccino	Grande	140Cal	", Price = 4.25},
        new Coffee {Id = 8, Name = "Cappuccino	Venti	200Cal	", Price = 4.75},
        new Coffee {Id = 9, Name = "Espresso	Solo	5Cal	", Price = 2.45},
        new Coffee {Id = 10, Name = "Espresso	Doppio	10Cal	", Price = 2.65},
        new Coffee {Id = 11, Name = "Espresso	Triple	15Cal	", Price = 2.95},
        new Coffee {Id = 12, Name = "Espresso	Quad	20Cal	", Price = 3.25},
        new Coffee {Id = 13, Name = "Espresso Con Panna	Solo	30Cal	", Price = 2.55},
        new Coffee {Id = 14, Name = "Espresso Con Panna	Doppio	35Cal	", Price = 2.75},
        new Coffee {Id = 15, Name = "Espresso Con Panna	Triple	40Cal	", Price = 3.05},
        new Coffee {Id = 16, Name = "Espresso Con Panna	Quad	45Cal	", Price = 3.35}
    };

    public List<Coffee> GetCoffees()
    {
        return _coffees;
    }
    public Coffee GetCoffee(int id)
    {
        return _coffees.FirstOrDefault(c => c.Id == id) ?? new Coffee() { Id = 0, Name = "Not Found", Price = 0};
    }
}