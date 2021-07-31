using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryUI : MonoBehaviour
{

    [SerializeField] Image foregroundIcon;

    void Update()
    {
        UpdateForegroundIcon();
    }

    void UpdateForegroundIcon()
    {
        foregroundIcon.fillAmount = Player.batteryPower;
    }
}
