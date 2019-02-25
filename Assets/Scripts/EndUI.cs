using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndUI : MonoBehaviour
{
    [SerializeField] private PlayerTriggerHandler player;
    [SerializeField] private GameObject components;
    [SerializeField] private Text endText;

    void Start() {
        components.SetActive(false);
    }

    void Update() {
        if(player.isWon) {
            endText.text = "You won!";
            components.SetActive(true);
        }
        if(player.outOfTime) {
            endText.text = "Out of time!";
            components.SetActive(true);
        }
        else if(player.isDead) {
            endText.text = "You died!";
            components.SetActive(true);
        }

    }
}
