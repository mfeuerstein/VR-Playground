using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	public GameObject remains;

	void OnCollisionEnter(Collision collision) {

		if (collision.relativeVelocity.magnitude > 40) {
			Instantiate (remains, transform.position, transform.rotation);
			System.Threading.Thread.Sleep (2);
			Destroy (gameObject);
		}
	}
}
