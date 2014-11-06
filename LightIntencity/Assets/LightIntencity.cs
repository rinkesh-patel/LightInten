using UnityEngine;
using System.Collections;

public class LightIntencity : MonoBehaviour {

	// Use this for initialization
	/*void Start () {
	
	}

	 Update is called once per frame*/
	public GameObject target;
	public Light source;
	//public float distance;
	//var other : Transform;




	void Update () 
	{
		var dist = Vector3.Distance( target.transform.position, transform.position);
		if (dist > 30) {
			//light.intensity = 0.1f;
			source.intensity = 0.0f;

				} else {
			//light.intensity = 5.0f;
			source.intensity = (30/dist);
				
		}
		Debug.Log ("Distance to other: " + 30/dist);
	}
}
