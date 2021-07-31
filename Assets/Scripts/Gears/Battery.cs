using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{

    [SerializeField] float power;

    void Update()
    {
        UpdatePlayer();
    }

    public void DrainBattery(float drainTime)
    {

        if (power > 0)
        {
            power -= (1.0f / drainTime) * Time.deltaTime;
            power = Mathf.Clamp(power, 0, 1);
        }

    }

    public bool HasCharge()
    {
        return Player.batteryPower > 0;
    }

    void UpdatePlayer()
    {

        Player.batteryPower = power;
    }
}
