using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EletronicGear : MonoBehaviour {

    [SerializeField] protected float drainTime;
    [SerializeField] protected KeyCode keycode;

    protected Battery battery;

    protected abstract void ToggleOn();
    protected abstract void ToggleOff();
}
