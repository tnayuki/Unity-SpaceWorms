using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormMoving : MonoBehaviour {
	public float speed = 10.0f;

	void Update() {
		var head = GetComponentInChildren<Rigidbody2D>();

		head.AddForce(new Vector3(Input.GetAxis(transform.parent.name + "_Horizontal") * speed, Input.GetAxis(transform.parent.name + "_Vertical") * speed, 0.0f));
	}
}
