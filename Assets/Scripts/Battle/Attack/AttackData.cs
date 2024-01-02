using System;
using UnityEngine;

[Serializable]
public class AttackData
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public int Power { get; private set; }
}
