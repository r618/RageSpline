using UnityEngine;
using System.Collections;

public class Rolling : MonoBehaviour {

    public float moveForce;
    public float gravity;
	public Prop prop;
	// Use this for initialization
	void Start () {
		prop = GetComponent(typeof(Prop)) as Prop;
	}

    void FixedUpdate()
    {
		if(prop.activeProp) {
        	GetComponent<Rigidbody>().AddForce(gravity * Vector3.down * Time.fixedDeltaTime, ForceMode.Force);
        	GetComponent<Rigidbody>().AddTorque(new Vector3(0f, 0f, (moveForce * Time.fixedDeltaTime) / (Mathf.Abs(GetComponent<Rigidbody>().velocity.x) + 0.1f)), ForceMode.Force);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
