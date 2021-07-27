using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Flashlight : MonoBehaviour {

    [SerializeField] GameObject flashlight;
    [SerializeField] float drainTime;

    private Battery battery;

    void Start() {
        flashlight.gameObject.SetActive(false);
        battery = GetComponent<Battery>();
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.F)) {

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

    private void ToggleOn() {
        flashlight.gameObject.SetActive(true);
        Player.flashlightOn = true;
    }

    private void ToggleOff() {
        flashlight.gameObject.SetActive(false);
        Player.flashlightOn = false;
    }

}


