using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDVisibility : MonoBehaviour
{

    [SerializeField] GameObject health;
    [SerializeField] GameObject battery;
    [SerializeField] GameObject inventory;

    private void Start()
    {
        health.SetActive(true);
        battery.SetActive(true);

        Cursor.visible = false;
    }

    void Update()
    {


    }

    public void SetInvetoryActive()
    {
        inventory.SetActive(true);
    }

    public void SetInvetoryDesactive()
    {
        inventory.SetActive(false);
    }

}
