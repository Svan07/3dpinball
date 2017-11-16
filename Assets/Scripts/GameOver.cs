using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    private bool start = true;
    [SerializeField]
    private GameObject boule, startPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && start)
        {
            float multiplier = Random.Range(0.8f, 1.2f);
            boule.GetComponent<Rigidbody>().AddForce(new Vector3(1 * multiplier,0,0));
            start = false;
        }
    }

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == boule)
        {
            boule.transform.position = startPoint.transform.position;
            start = true;
        }
    }
}
