using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EletronicGear : MonoBehaviour {

    [SerializeField] protected float drainTime;
    [SerializeField] protected KeyCode keycode;
    [SerializeField] protected bool active;

    protected Battery battery;

    protected void Update() {

        if (Input.GetKeyDown(keycode)) {

            if (active == false) {

                if (battery.HasCharge()) {
                    ToggleOn();
                }

            } else {
                ToggleOff();
            }
        }

        if (active) {
            battery.DrainBattery(drainTime);
        }

        if (!battery.HasCharge()) {
            ToggleOff();
        }

    }

    protected abstract void ToggleOn();
    protected abstract void ToggleOff();
}
