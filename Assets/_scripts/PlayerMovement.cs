using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody _rigidbody;
	private Vector3 movement;
	private float xInput;
	private float yInput;
	public float speed;

	void Awake () {
		_rigidbody = GetComponent<Rigidbody> ();
	}


	void Update () {
		xInput = Input.GetAxisRaw("Horizontal");
		yInput = Input.GetAxisRaw ("Vertical");

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Plane plane = new Plane (Vector3.up, Vector3.zero);
		float distance;
		if (plane.Raycast (ray, out distance)) {
			Vector3 point = ray.GetPoint (distance);

			Vector3 adjustedHeightPoint = new Vector3(point.x, transform.position.y,point.z);
			transform.LookAt(adjustedHeightPoint);
		}
		if (transform.position.y <= -10) {
			Debug.Log ("slet");
			Application.LoadLevel ("MainMenu");
		}
	}


	void FixedUpdate () {
		Vector3 direction = new Vector3 (xInput, 0f, yInput);
		Vector3 velocity = direction.normalized * speed * Time.fixedDeltaTime;
		_rigidbody.MovePosition (_rigidbody.position + velocity);
	}
}
