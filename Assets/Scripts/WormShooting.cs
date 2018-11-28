using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormShooting : MonoBehaviour {
	void Update () {
		if (Input.GetButtonDown(transform.parent.name + "_Fire")) {
			var joint = GetComponent<HingeJoint2D>();

			var shoot = joint.connectedBody;

			var joint2 = shoot.GetComponent<HingeJoint2D>();
			if (joint2) {
				joint2.enabled = false;

				var body = joint2.connectedBody;
				if (body) {
					joint.connectedBody = body.GetComponent<Rigidbody2D>();

					transform.position = body.transform.position;
				}
			} else {
				joint.connectedBody = null;
			}

			shoot.gameObject.AddComponent<ShootCollision>();
			shoot.AddForce(shoot.transform.up * 100.0f);
		}

		GetComponent<HingeJoint2D>().enabled = true;
	}
}
