using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    [SerializeField] GameObject invetory;
    [SerializeField] KeyCode keyCode;
    [SerializeField] bool active;

    [SerializeField] GameObject AppleImage1;
    [SerializeField] GameObject AppleButton1;

    [SerializeField] GameObject BatteryImage1;
    [SerializeField] GameObject BatteryButton1;
    [SerializeField] GameObject BatteryImage2;
    [SerializeField] GameObject BatteryButton2;
    [SerializeField] GameObject BatteryImage3;
    [SerializeField] GameObject BatteryButton3;
    [SerializeField] GameObject BatteryImage4;
    [SerializeField] GameObject BatteryButton4;

    private void Start()
    {
        ResetInventory();


    }

    void Update()
    {
        ResetInventory();

        if (Input.GetKeyDown(keyCode))
        {

            if (active == false)
            {
                ToggleOn();
            }
            else
            {
                ToggleOff();
            }
        }

        CheckInvetory();

    }

    private void ToggleOn()
    {
        invetory.SetActive(true);
        active = true;

        Cursor.visible = true;

        Time.timeScale = 0f;
    }

    private void ToggleOff()
    {
        invetory.SetActive(false);
        active = false;

        Cursor.visible = false;

        Time.timeScale = 1f;
    }

    private void CheckInvetory()
    {
        if (Player.apples >= 1)
        {
            AppleImage1.gameObject.SetActive(true);
            AppleButton1.gameObject.SetActive(true);
        }

        // Batteries
        if (Player.batteries >= 1)
        {
            BatteryImage1.gameObject.SetActive(true);
            BatteryButton1.gameObject.SetActive(true);
        }
        if (Player.batteries >= 2)
        {
            BatteryImage2.gameObject.SetActive(true);
            BatteryButton2.gameObject.SetActive(true);
        }
        if (Player.batteries >= 3)
        {
            BatteryImage3.gameObject.SetActive(true);
            BatteryButton3.gameObject.SetActive(true);
        }
        if (Player.batteries >= 4)
        {
            BatteryImage4.gameObject.SetActive(true);
            BatteryButton4.gameObject.SetActive(true);
        }
    }

    public void IncreaseHealth()
    {
        Player.playerHealth += 10;
        Player.apples--;
        Player.healthChanged = true;
    }

    public void IncreaseBattery()
    {
        Player.isChargingBattery = true;
        Player.batteries--;
    }

    private void ResetInventory()
    {
        AppleImage1.gameObject.SetActive(false);
        AppleButton1.gameObject.SetActive(false);

        BatteryImage1.gameObject.SetActive(false);
        BatteryButton1.gameObject.SetActive(false);
        BatteryImage2.gameObject.SetActive(false);
        BatteryButton2.gameObject.SetActive(false);
        BatteryImage3.gameObject.SetActive(false);
        BatteryButton3.gameObject.SetActive(false);
        BatteryImage4.gameObject.SetActive(false);
        BatteryButton4.gameObject.SetActive(false);
    }
}
