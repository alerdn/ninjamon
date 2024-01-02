using System;
using UnityEngine;

[CreateAssetMenu]
public class Inputs : ScriptableObject
{
    public event Action<AttackData> OnAttack;

    public void Attack(AttackData attack)
    {
        OnAttack?.Invoke(attack);
    }
}
