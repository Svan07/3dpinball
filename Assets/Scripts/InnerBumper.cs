using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerBumper : MonoBehaviour {

    [SerializeField]
    private KeyCode kfc ;

    private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(kfc))
        {
            rigidBody.AddForce(new Vector3(11,0,0));
        }
        if (Input.GetKeyUp(kfc))
        {
            rigidBody.AddForce(new Vector3(-2, 0, 0));
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "Boule")
        {
            collision.collider.GetComponent<Rigidbody>().AddForce(0.01f * collision.collider.GetComponent<Rigidbody>().velocity);
        }
    }
}
