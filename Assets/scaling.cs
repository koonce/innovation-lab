using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaling : MonoBehaviour {

	private float time;
	private Transform objSize;
	private Vector3 largeSize, smallSize;
	void Start(){
		time = 60f;
		objSize = GetComponent<Transform>();
		largeSize = new Vector3 (100, 100, 100);
		smallSize = new Vector3 (.1f, .1f, .1f);
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time >= 30) {
			//objects get larger over these 30 seconds
			objSize.localScale = Vector3.Lerp (objSize.localScale, smallSize, Time.deltaTime);
		} else if(time >= 0){
			objSize.localScale = Vector3.Lerp (objSize.localScale, largeSize, Time.deltaTime);
		}

		if (time <= 0) {
			objSize.localScale = Vector3.Lerp (objSize.localScale, smallSize, Time.deltaTime);
		}


	}
}
