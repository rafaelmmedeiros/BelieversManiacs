using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSound : MonoBehaviour
{

    [SerializeField] bool oneTime = false;
    [SerializeField] float pauseTime = 5.0f;

    private AudioSource audioSource;
    private new Collider collider;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            audioSource.Play();
            collider.enabled = false;

            if (oneTime == false)
            {
                StartCoroutine(Reset());
            }
            else
            {
                Destroy(gameObject, pauseTime);
            }
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(pauseTime);
        collider.enabled = true;
    }
}
