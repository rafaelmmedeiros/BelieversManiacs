using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int playerHealth = 100;
    public static bool healthChanged = false;

    public static float batteryPower = 1f;
    public static bool isChargingBattery = false;

    public static int apples = 0;
    public static int batteries = 0;

    public static bool flashlightOn = false;
    public static bool nightvisionOn = false;

}