using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LightSettingsPlayer : MonoBehaviour {

    [SerializeField] PostProcessVolume postProcessVolume;
    [SerializeField] PostProcessProfile standard;
    [SerializeField] PostProcessProfile nightVision;
    [SerializeField] GameObject nightVisionOverlay;
    [SerializeField] GameObject flashlight;

    private bool nightVisionActive = false;
    private bool flashlightActive = false;

    void Start() {

        nightVisionOverlay.gameObject.SetActive(false);
        flashlight.gameObject.SetActive(false);

    }

    void Update() {

        toggleNightVision();
        toggleFlashlight();

    }

    private void toggleNightVision() {

        if (Input.GetKeyDown(KeyCode.N)) {

            if (nightVisionActive == false) {
                postProcessVolume.profile = nightVision;
                nightVisionActive = true;
                nightVisionOverlay.gameObject.SetActive(true);
            } else {
                postProcessVolume.profile = standard;
                nightVisionActive = false;
                nightVisionOverlay.gameObject.SetActive(false);
            }

        }
    }

    private void toggleFlashlight() {

        if (Input.GetKeyDown(KeyCode.F)) {

            if (flashlightActive == false) {
                flashlight.gameObject.SetActive(true);
                flashlightActive = true;
            } else {
                flashlight.gameObject.SetActive(false);
                flashlightActive = false;
            }

        }
    }
}


