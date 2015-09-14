using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float velocidad = 30f;
	public float maxima_d = 12f;

	void Update () {
		transform.Translate(new Vector3(0,0,-1)*velocidad*Time.deltaTime);	
		if(transform.position.z < -maxima_d){
			Destroy(gameObject);
		}
	}
}
