using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseColider : MonoBehaviour {

    public Level_Manager levelManager;
    void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Trigger");
        levelManager.LoadLevel("Lose");
    }


     void OnCollisionEnter2D(Collision2D collision)
    {
        print("Colision");
    }
}