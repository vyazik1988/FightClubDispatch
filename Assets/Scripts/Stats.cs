using UnityEngine;

[System.Serializable]
public struct Stats
{
    public int strength;
    public int vigor;
    public int agility;
    public int intellect;
    public int charisma;

    public static Stats operator +(Stats a, Stats b)
    {
        return new Stats
        {
            strength = a.strength + b.strength,
            vigor = a.vigor + b.vigor,
            agility = a.agility + b.agility,
            intellect = a.intellect + b.intellect,
            charisma = a.charisma + b.charisma
        };
    }
}
