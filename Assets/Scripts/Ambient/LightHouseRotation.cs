using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHouseRotation : MonoBehaviour
{

    [SerializeField] GameObject lightHouseLight;
    [SerializeField] float speed = 0.1f;

    void Update()
    {
        lightHouseLight.transform.Rotate(0.0f, speed, 0.0f, Space.World);
    }
}
