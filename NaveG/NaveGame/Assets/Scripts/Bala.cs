using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {
	public float velocidad = 30f;
	public float maxima_d = 12f;

	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,1,0)*velocidad*Time.deltaTime);

		if(transform.position.z > maxima_d){
			Destroy(gameObject);

		}
	
	}

	void Start(){
		transform.Rotate (90, 0, 0);
	}
}