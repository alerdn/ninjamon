using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public static ScreenManager Instance;

    [SerializeField] private List<Screen> _screens;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Show(ScreenType.ACTIONS);
    }

    public void Show(ScreenType type)
    {
        foreach (Screen screen in _screens)
        {
            if (screen.Type != type) screen.Hide();
            else screen.Show();
        }
    }

}
