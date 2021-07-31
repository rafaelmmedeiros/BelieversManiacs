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

    private void Start()
    {
        AppleImage1.gameObject.SetActive(false);
        AppleButton1.gameObject.SetActive(false);
    }

    void Update()
    {

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
    }

    public void IncreaseHealth()
    {
        Player.playerHealth += 10;
        Player.apples--;
        Player.healthChanged = true;

        AppleImage1.gameObject.SetActive(false);
        AppleButton1.gameObject.SetActive(false);
    }

    public void IncreaseBattery()
    {
        Player.batteryPower = 1;
        Player.batteries--;
    }
}
