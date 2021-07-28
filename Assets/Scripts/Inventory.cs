using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    [SerializeField] GameObject invetory;
    [SerializeField] KeyCode keyCode;
    [SerializeField] bool active;

    void Update() {

        if (Input.GetKeyDown(keyCode)) {

            if (active == false) {
                ToggleOn();
            } else {
                ToggleOff();
            }
        }

    }

    private void ToggleOn() {
        invetory.SetActive(true);
        active = true;

        Cursor.visible = true;

        Time.timeScale = 0f;
    }

    private void ToggleOff() {
        invetory.SetActive(false);
        active = false;

        Cursor.visible = false;

        Time.timeScale = 1f;
    }
}
