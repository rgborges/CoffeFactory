namespace coffee.factory.httpserver.Services
{
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
    public class MemoryCatalogService : IProductCatalogService
    {
        public double GetPrice(object product)
        {
            //Dummy funciton for testing
            if (product is EspressoCoffee)
            {
                return 2.25;
            }
            else
            {
                return 3.45;
            }
        }
    }
}
