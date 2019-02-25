using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private PlayerTriggerHandler player;
    [SerializeField] private Text text;

    void Update() {
        text.text = player.health.ToString() + "/" + player.maxHealth.ToString();
    }
}
