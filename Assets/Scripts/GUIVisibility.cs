using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIVisibility : MonoBehaviour {

    [SerializeField] GameObject health;
    [SerializeField] GameObject battery;
    [SerializeField] GameObject inventory;

    private void Start() {
        health.SetActive(true);
        battery.SetActive(true);
        inventory.SetActive(false);
    }

    void Update() {

        //if (SaveScript.flashlightOn || SaveScript.nightvisionOn) {
        //    battery.SetActive(true);
        //} else {
        //    battery.SetActive(false);
        //}

    }

    public void SetInvetoryActive() {
        inventory.SetActive(true);
    }

    public void SetInvetoryDesactive() {
        inventory.SetActive(false);
    }

}
