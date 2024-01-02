using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenHelper : MonoBehaviour
{
    [SerializeField] private ScreenType _targetType;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SwitchScreen);
    }

    private void SwitchScreen()
    {
        ScreenManager.Instance.Show(_targetType);
    }
}
