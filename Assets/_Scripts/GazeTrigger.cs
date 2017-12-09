using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeTrigger : MonoBehaviour
{

	public Camera PlayerCamera;
	public AudioSource AS;
	public bool musicPlay;

	// Use this for initialization
	void Start()
	{

		AS = this.gameObject.GetComponent<AudioSource>();
		musicPlay = false;
	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log("update");
		Vector3 camLookDir = PlayerCamera.transform.forward;

		Vector3 VectorFromCamToTarget = transform.position - PlayerCamera.transform.position;

		float angle = Vector3.Angle(camLookDir, VectorFromCamToTarget);

		if (angle < 15f * transform.localScale.x)
		{

			if (musicPlay == false)
			{

				Debug.Log("looked");

				AS.Play();

				musicPlay = true;

			}

		}
		else
		{
			AS.Pause();
			musicPlay = false;
		}
	}
}
