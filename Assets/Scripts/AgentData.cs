using UnityEngine;

public class AgentData
{
    public string specialistName;
    public Stats stats;
    public AgentState currentState;

    public string specialistID;

    public AgentData(string id, string name, Stats baseStats)
    {
        this.specialistID = id;
        this.specialistName = name;
        this.stats = baseStats;
        this.currentState = AgentState.Idle;
    }
}
