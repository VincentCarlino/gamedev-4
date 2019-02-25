using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerHandler : MonoBehaviour
{
    public int maxHealth = 3;
    public int health = 3;
	public int count = 0;
	public bool isDead = false;
    public bool isWon = false;
    public bool outOfTime = false;
    public bool canMove = true;

    private int maxPickup;

    void Start() {
        maxPickup = GameObject.FindGameObjectsWithTag("Pickup").Length;

    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Obstacle"  && !isDead) {
            health--;
            if(health <= 0) {
                isDead = true;
                canMove = false;
            }
        }
    }



    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Pickup")) {
            other.gameObject.SetActive(false);
            count ++;
        }
        if(other.gameObject.CompareTag("Goal") && count == maxPickup) {
            isWon = true;
            canMove = false;
        }
    }


}
