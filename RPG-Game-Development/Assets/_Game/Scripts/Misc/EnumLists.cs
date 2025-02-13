public enum StatsType
{
    Health,
    Speed,
    Mana,
    Defense
}

[System.Serializable]
public class StatModifier
{
    public StatsType type;
    public int value;

    public StatModifier(StatsType type, int value)
    {
        this.type = type;
        this.value = value;
    }
}

[System.Serializable]
public enum ItensType
{
    Equipment,
    Usable,
    Elixir,
    Crystal
}


[System.Serializable]
public enum SlotsType
{
    Inventory,
    Helmet,
    Armor,
    Legs,
    Boots,
    Necklace,
    Weapon,
    Ring
}
