using UnityEngine;
using System.Collections;

public class Bglouper : MonoBehaviour {
	int numBgPanels = 12;

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log ("Triggered: " + collider.name);

	float widthObj =((BoxCollider2D)collider).size.x;

		Vector3 pos = collider.transform.position;

		pos.x += widthObj*numBgPanels - widthObj/2f;

		collider.transform.position = pos;
	}
}