using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Nightvision : MonoBehaviour {

    [SerializeField] PostProcessVolume postProcessVolume;
    [SerializeField] PostProcessProfile standard;
    [SerializeField] PostProcessProfile nightVision;
    [SerializeField] GameObject nightVisionOverlay;
    [SerializeField] float drainTime;

    private Battery battery;

    void Start() {
        nightVisionOverlay.gameObject.SetActive(false);
        battery = GetComponent<Battery>();
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.N)) {

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

    private void ToggleOn() {
        postProcessVolume.profile = nightVision;
        nightVisionOverlay.gameObject.SetActive(true);
        Player.nightvisionOn = true;
    }

    private void ToggleOff() {
        postProcessVolume.profile = standard;
        nightVisionOverlay.gameObject.SetActive(false);
        Player.nightvisionOn = false;
    }
}


