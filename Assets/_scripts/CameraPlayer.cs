using UnityEngine;
using System.Collections;

public class CameraPlayer : MonoBehaviour {

	public Vector3 offset;
	public Transform follow;
	public float speed;

	void Update () {
		if(follow) transform.position = Vector3.Lerp(transform.position, follow.position + offset, speed * Time.deltaTime);
	}
}