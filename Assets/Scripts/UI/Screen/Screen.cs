using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ScreenType
{
    NONE,
    ACTIONS,
    ATTACKS
}

public class Screen : MonoBehaviour
{
    [field: SerializeField] public ScreenType Type { get; private set; }

    [SerializeField] private GameObject _content;

    public void Show()
    {
        _content.SetActive(true);
    }

    public void Hide()
    {
        _content.SetActive(false);
    }
}
