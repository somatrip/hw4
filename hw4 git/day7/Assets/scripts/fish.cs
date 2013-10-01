using UnityEngine;
using System.Collections;

public class fish : MonoBehaviour {
	
	public Vector3 destination = new Vector3 (100f, 100f, 100f);
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		
		//keep repeating ____ function, after delay of 0 s, repeat every 15 seconds
		InvokeRepeating("SetNewDestination", 0f, 3.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.LookRotation ( rigidbody.velocity * Time.deltaTime );
	}
	
	void FixedUpdate() {
		//rigidbody.AddForce( destination - transform.position );
		Vector3 direction = Vector3.Normalize( destination - transform.position);
		rigidbody.AddForce (direction * speed, ForceMode.Acceleration);	
		
	}
	
	public void SetNewDestination() {
		//set a random destination
		SetNewDestination ( Random.insideUnitSphere * 50f );
		
	}
	
	 public void SetNewDestination (Vector3 newDestination) {
        destination = newDestination;
    }
		
	
}
