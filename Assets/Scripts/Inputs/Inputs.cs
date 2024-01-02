using System;
using UnityEngine;

[CreateAssetMenu]
public class Inputs : ScriptableObject
{
    public event Action<AttackData> OnAttack;
    public event Action OnHeal;

    public void Attack(AttackData attack)
    {
        OnAttack?.Invoke(attack);
    }

    public void Heal()
    {
        OnHeal?.Invoke();
    }
}
