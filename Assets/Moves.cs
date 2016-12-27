using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour {
	Vector3 velocity = Vector3.zero;
	float flapspeed = 100f;
	float forSpeed = 1f;
	private Rigidbody2D rb ;
	bool didflap = false ;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	//Do graphic and input here
	void Update(){
		if (Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0)) {
			didflap = true ;
		}
	}
		// Do physic update here 
	void FixedUpdate () {
		/*rb.AddForce(Vector2.up * forSpeed);
		if (didflap) {
			rb.AddForce(Vector2.up * flapspeed);
			didflap = false ;*/
		}


}
