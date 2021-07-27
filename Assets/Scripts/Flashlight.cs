using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Flashlight : MonoBehaviour {

    [SerializeField] GameObject flashlight;

    void Start() {
        flashlight.gameObject.SetActive(false);
    }

    void Update() {

        ToggleFlashlight();
    }

    private void ToggleFlashlight() {

        if (Input.GetKeyDown(KeyCode.F)) {

            if (Player.flashlightOn == false) {
                flashlight.gameObject.SetActive(true);
                Player.flashlightOn = true;
            } else {
                flashlight.gameObject.SetActive(false);
                Player.flashlightOn = false;
            }

        }
    }
}


