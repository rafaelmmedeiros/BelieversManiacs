using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : EletronicGear
{

    [SerializeField] GameObject flashlight;

    void Start()
    {
        flashlight.gameObject.SetActive(false);
        battery = GetComponent<Battery>();
        active = Player.flashlightOn;
    }

    protected override void ToggleOn()
    {
        flashlight.gameObject.SetActive(true);
        active = true;

        Player.flashlightOn = true;
    }

    protected override void ToggleOff()
    {
        flashlight.gameObject.SetActive(false);
        active = false;

        Player.flashlightOn = false;
    }

}


