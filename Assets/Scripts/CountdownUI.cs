using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownUI : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private float maxTimer;
    [SerializeField] private PlayerTriggerHandler player;

    private float timer;

    void Start()
    {
        timer = maxTimer;
    }

    void Update()
    {
        if(!player.isWon || player.isDead) {
            if(timer > 0.0f) {
                timer -= Time.deltaTime;
                text.text = timer.ToString("F");
            }
            else if(timer <= 0.0f)
            {
                text.text = "O.OO";
                timer = 0.0f;
                player.outOfTime = true;
            }
        }

    }

}
