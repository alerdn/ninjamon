using System;

public enum StatType
{
    STRENGTH,
    SPEED
}

[Serializable]
public class Stat
{
    public StatType Type;
    public int Value;
}