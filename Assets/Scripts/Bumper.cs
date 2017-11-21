using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bumper : MonoBehaviour {

    [SerializeField]
    private float multiplicator;
    [SerializeField]
    private int value;
    
    private string textScore;



    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "Boule")
        {
            collision.collider.GetComponent<Rigidbody>().AddForce(multiplicator * collision.collider.GetComponent<Rigidbody>().velocity);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Boule")
        {
            GlobalVariables.score += value;
        }
    }
}
