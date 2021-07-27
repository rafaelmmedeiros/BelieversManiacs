using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Nightvision : EletronicGear {

    [SerializeField] PostProcessVolume postProcessVolume;
    [SerializeField] PostProcessProfile standard;
    [SerializeField] PostProcessProfile nightVision;
    [SerializeField] GameObject nightVisionOverlay;

    void Start() {
        nightVisionOverlay.gameObject.SetActive(false);
        battery = GetComponent<Battery>();
    }

    void Update() {

        if (Input.GetKeyDown(keycode)) {

            if (Player.nightvisionOn == false) {

                if (battery.HasCharge()) {
                    ToggleOn();
                }

            } else {
                ToggleOff();
            }
        }

        if (Player.nightvisionOn) {
            battery.DrainBattery(drainTime);
        }

        if (!battery.HasCharge()) {
            ToggleOff();
        }
    }

    protected override void ToggleOn() {
        postProcessVolume.profile = nightVision;
        nightVisionOverlay.gameObject.SetActive(true);
        Player.nightvisionOn = true;
    }

    protected override void ToggleOff() {
        postProcessVolume.profile = standard;
        nightVisionOverlay.gameObject.SetActive(false);
        Player.nightvisionOn = false;
    }
}


