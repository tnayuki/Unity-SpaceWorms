using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCollision : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.CompareTag("Wall")) {
			Destroy(gameObject);
		} else if (CompareTag("Player1") && other.collider.CompareTag("Player2") || CompareTag("Player2") && other.collider.CompareTag("Player1")) {
			Destroy(gameObject);

			var obj = other.gameObject;

			while (obj) {
				Destroy(obj);

				var joint = obj.GetComponent<HingeJoint2D>();
				if (!joint) break;

				obj = joint.connectedBody.gameObject;
			}
		}
	}
}
