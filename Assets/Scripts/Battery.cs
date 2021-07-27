using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour {

    [SerializeField] Image foregroundIcon;
    [SerializeField] float drainTimeFlashlight;
    [SerializeField] float drainTimeNightvision;
    [SerializeField] float power;

    void Update() {
        DrainBattery();
        UpdateForegroundIcon();
        UpdateSaveScript();
    }

    void DrainBattery() {

        if (Player.flashlightOn) {
            if (power > 0) {
                power -= (1.0f / drainTimeFlashlight) * Time.deltaTime;
                power = Mathf.Clamp(power, 0, 1);
            }
        }

        if (Player.nightvisionOn) {
            if (power > 0) {
                power -= (1.0f / drainTimeNightvision) * Time.deltaTime;
                power = Mathf.Clamp(power, 0, 1);
            }
        }
    }

    void UpdateForegroundIcon() {
        foregroundIcon.fillAmount = power;
    }

    void UpdateSaveScript() {

        Player.batteryPower = power;

    }
}
