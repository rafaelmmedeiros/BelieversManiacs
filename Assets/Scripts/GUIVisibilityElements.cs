using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIVisibilityElements : MonoBehaviour {

    [SerializeField] GameObject health;
    [SerializeField] GameObject battery;

    private void Start() {
        health.SetActive(true);
        battery.SetActive(true);
    }

    void Update() {

        //if (SaveScript.flashlightOn || SaveScript.nightvisionOn) {
        //    battery.SetActive(true);
        //} else {
        //    battery.SetActive(false);
        //}

    }
}
