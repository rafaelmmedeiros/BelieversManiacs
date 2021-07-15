using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LightSettingsPlayer : MonoBehaviour {

    [SerializeField] PostProcessVolume postProcessVolume;
    [SerializeField] PostProcessProfile standard;
    [SerializeField] PostProcessProfile nightVision;
    [SerializeField] GameObject nightVisionOverlay;

    private bool nightVisionActive = false;

    void Start() {

        nightVisionOverlay.gameObject.SetActive(false);
    }

    void Update() {

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
}
