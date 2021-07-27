using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Nightvision : MonoBehaviour {

    [SerializeField] PostProcessVolume postProcessVolume;
    [SerializeField] PostProcessProfile standard;
    [SerializeField] PostProcessProfile nightVision;
    [SerializeField] GameObject nightVisionOverlay;

    void Start() {
        nightVisionOverlay.gameObject.SetActive(false);
    }

    void Update() {

        ToggleNightVision();
    }

    private void ToggleNightVision() {

        if (Input.GetKeyDown(KeyCode.N)) {

            if (Player.nightvisionOn == false) {
                postProcessVolume.profile = nightVision;
                nightVisionOverlay.gameObject.SetActive(true);
                Player.nightvisionOn = true;
            } else {
                postProcessVolume.profile = standard;
                nightVisionOverlay.gameObject.SetActive(false);
                Player.nightvisionOn = false;
            }

        }
    }
}


