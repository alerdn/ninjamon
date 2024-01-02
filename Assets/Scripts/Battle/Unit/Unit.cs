using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [field: SerializeField] public int MaxHP { get; private set; }
    [field: SerializeField] public int CurrentHP { get; private set; }
    [field: SerializeField] public List<AttackData> Attacks { get; private set; }
    [field: SerializeField] public List<Stat> Stats { get; private set; }


    public int GetStat(StatType type)
    {
        Stat stat = Stats.Find(stat => stat.Type == type);
        if (stat != null) return stat.Value;
        else return 0;
    }

    public void Damage(int damage)
    {
        if (CurrentHP <= 0) return;

        CurrentHP = Mathf.Max(CurrentHP - damage, 0);
        if (CurrentHP <= 0) Kill();
    }

    private void Kill()
    {
        Debug.Log($"{this.name} is dead");
    }

    public void Heal(int amount)
    {
        CurrentHP = Mathf.Min(CurrentHP + amount, MaxHP);
    }
}