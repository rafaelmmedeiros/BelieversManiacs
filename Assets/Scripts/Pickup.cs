using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    RaycastHit raycastHit;
    [SerializeField] float distance;
    [SerializeField] GameObject pickupMessage;

    private float raycastDistance;
    private bool pickupInRange;

    void Start()
    {

        pickupInRange = false;
        pickupMessage.gameObject.SetActive(false);
        raycastDistance = distance;
    }

    void Update()
    {

        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, raycastDistance))
        {

            if (raycastHit.transform.tag == "Apple")
            {
                pickupInRange = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(raycastHit.transform.gameObject);
                    Player.apples++;
                }
            }
            else if (raycastHit.transform.tag == "Battery")
            {
                pickupInRange = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(raycastHit.transform.gameObject);
                    Player.batteries++;
                }
            }
            else
            {
                pickupInRange = false;
            }

        }

        if (pickupInRange == true)
        {
            pickupMessage.gameObject.SetActive(true);
            raycastDistance = 1000f;
        }

        if (pickupInRange == false)
        {
            pickupMessage.gameObject.SetActive(false);
            raycastDistance = distance;
        }
    }
}
