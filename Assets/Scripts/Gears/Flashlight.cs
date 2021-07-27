using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Flashlight : EletronicGear {

    [SerializeField] GameObject flashlight;

    void Start() {
        flashlight.gameObject.SetActive(false);
        battery = GetComponent<Battery>();
    }

    void Update() {

        if (Input.GetKeyDown(keycode)) {

            if (Player.flashlightOn == false) {

                if (battery.HasCharge()) {
                    ToggleOn();
                }

            } else {
                ToggleOff();
            }
        }

        if (Player.flashlightOn) {
            battery.DrainBattery(drainTime);
        }

        if (!battery.HasCharge()) {
            ToggleOff();
        }

    }

    protected override void ToggleOn() {
        flashlight.gameObject.SetActive(true);
        Player.flashlightOn = true;
    }

    protected override void ToggleOff() {
        flashlight.gameObject.SetActive(false);
        Player.flashlightOn = false;
    }

}


