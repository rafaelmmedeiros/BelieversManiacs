using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour {

    private bool classDebuMode = true;

    [SerializeField] Image foregroundIcon;
    [SerializeField] float drainTime = 15.0f;
    [SerializeField] float power = 1.0f;

    void Update() {
        DrainBattery();
        SetForegroundIcon();
        UpdateSaveScript();
    }

    void DrainBattery() {

        if (power > 0) {
            power -= (1.0f / drainTime) * Time.deltaTime;

            if (power < 0) {
                power = 0;
            }
        }
    }

    void SetForegroundIcon() {
        foregroundIcon.fillAmount = power;
    }

    void UpdateSaveScript() {

        SaveScript.batteryPower = power;

        // Class Debug
        if (classDebuMode) {
            Debug.Log(SaveScript.batteryPower);
        }
    }
}
