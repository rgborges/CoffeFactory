internal class Cup 
{
    private Coffee? _liquid;
    private int _maxCapacityVolume;
    private int _innerVolume;

    public int InnerVolume { get => _innerVolume; }

    public Cup(int volume)
    {
        this._maxCapacityVolume = volume;
    }
    public void Fill(Coffee coffee)
    {
        for(int i = 0; i < _maxCapacityVolume; i++)
        {
            _innerVolume ++;   
        }
        this._liquid = coffee;
    }
    public override string ToString()
    {
        if(_liquid is null)
            return $"Cup with Maximum Capacity: {this._maxCapacityVolume}, {this._innerVolume} is filled right";
        else
        {
            return $"Cup with Maximum Capacity: {this._maxCapacityVolume}, {this._innerVolume} is filled right with {_liquid.ToString()}";
        }
        
    }
}