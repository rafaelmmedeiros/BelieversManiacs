using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Nightvision : EletronicGear
{

    [SerializeField] PostProcessVolume postProcessVolume;
    [SerializeField] PostProcessProfile standard;
    [SerializeField] PostProcessProfile nightVision;
    [SerializeField] GameObject nightVisionOverlay;

    void Start()
    {
        nightVisionOverlay.gameObject.SetActive(false);
        battery = GetComponent<Battery>();
        active = Player.nightvisionOn;
    }

    protected override void ToggleOn()
    {
        postProcessVolume.profile = nightVision;
        nightVisionOverlay.gameObject.SetActive(true);
        active = true;

        Player.nightvisionOn = true;
    }

    protected override void ToggleOff()
    {
        postProcessVolume.profile = standard;
        nightVisionOverlay.gameObject.SetActive(false);
        active = false;

        Player.nightvisionOn = false;
    }
}


