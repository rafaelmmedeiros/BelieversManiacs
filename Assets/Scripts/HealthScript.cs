using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    [SerializeField] Text healthText;

    void Start() {

        UpdateHealthAmounth();
    }

    void Update() {

        // Gambiarra temporaria, trocar tudo para sistema de events
        // Coisa feia...

        if (SaveScript.healthChanged) {
            UpdateHealthAmounth();
            SaveScript.healthChanged = false;
        }

    }

    private void UpdateHealthAmounth() {
        healthText.text = SaveScript.playerHealth + "%";
    }
}
