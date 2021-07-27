using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour {

    [SerializeField] Text healthText;

    void Start() {

        UpdateHealthAmounth();
    }

    void Update() {

        if (Player.healthChanged) {
            UpdateHealthAmounth();
            Player.healthChanged = false;
        }

    }

    private void UpdateHealthAmounth() {
        healthText.text = Player.playerHealth + "%";
    }
}
