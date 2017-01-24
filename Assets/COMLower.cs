using UnityEngine;
using System.Collections;

public class COMLower : MonoBehaviour {
    Vector3 com;
    Rigidbody rb;
	public float comOffeset;

	public GameObject cube;

    void Start() {
        rb = GetComponent<Rigidbody>();
		com = new Vector3(rb.transform.position.x, rb.transform.position.y + comOffeset, rb.transform.position.z);
        rb.centerOfMass = com;
		cube.transform.position = com;
    }
}