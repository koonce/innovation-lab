using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeTrigger : MonoBehaviour {

	public Camera PlayerCamera;
	public AudioSource AS;

	// Use this for initialization
	void Start () {

		AS = this.gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 camLookDir = PlayerCamera.transform.forward;

		Vector3 VectorFromCamToTarget = transform.position - PlayerCamera.transform.position;

		float angle = Vector3.Angle (camLookDir, VectorFromCamToTarget);

		if (angle < 15f * transform.localScale.x) {

			AS.Play ();
		}
		else {
			AS.Pause();
		}
}
