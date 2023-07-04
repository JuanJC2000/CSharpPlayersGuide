//todo 
//make functions for get of each each type, return them and then ask the user for stuff
ArrowHeads arrow = GetArrow();
Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");

ArrowHeads GetArrow()
{
    ArrowHeadType arrowHead = GetArrowheadType();
    FlecthingTypes flecthing = GetFletchingType();
    double length = GetLength();

    return new ArrowHeads(arrowHead, flecthing, length);
}
ArrowHeadType GetArrowheadType()
{
    Console.Write("Arrowhead type (steel, wood, obsidian): ");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => ArrowHeadType.Steel,
        "wood" => ArrowHeadType.Wood,
        "obsidian" => ArrowHeadType.Obsidian
    };
}

FlecthingTypes GetFletchingType()
{
    Console.WriteLine("Fletching type (plastic, turkey feather, goose feather): ");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => FlecthingTypes.Plastic,
        "turkey feather" => FlecthingTypes.TurkeyFeathers,
        "goose feather" => FlecthingTypes.GooseFeathers
    };
}

double GetLength()
{
    float length = 0;
    while(length < 60 || length > 100)
    {
        Console.Write("Arrow length (between 60 and 100): ");
        length = Convert.ToSingle(Console.ReadLine());

        
    }

    return (double)length;
}







class ArrowHeads
{
    public ArrowHeadType _arrowHead;
    public FlecthingTypes _fletching;
    public double _shaftLength;

    public ArrowHeads(ArrowHeadType arrowhead, FlecthingTypes fletching, double length)
    {
        _arrowHead = arrowhead;
        _fletching = fletching;
        _shaftLength = length;
    }

    public float GetCost()
    {
        float arrowheadCost = _arrowHead switch
        {
            ArrowHeadType.Steel => 10,
            ArrowHeadType.Wood => 3,
            ArrowHeadType.Obsidian => 5
        };

        float fletchingCost = _fletching switch
        {
            FlecthingTypes.Plastic => 10,
            FlecthingTypes.TurkeyFeathers => 5,
            FlecthingTypes.GooseFeathers => 3
        };

        float shaftCost = (float)0.05 * (float)_shaftLength;

        return arrowheadCost + fletchingCost + shaftCost;
    }
}

enum ArrowHeadType
{
    Steel,
    Wood,
    Obsidian

}

enum FlecthingTypes
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}