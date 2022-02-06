internal class Cup 
{
    private Coffee? _liquid;

    public Cup(){ }
    public void Fill(Coffee coffee)
    {
        this._liquid = coffee;
    }
}