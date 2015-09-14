using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	//dificultad del enemigo
	public float NPM = 60f;
	public GameObject Enemigo;
	public float rango = 19f;
	public bool disponible =true;


	void Update () {
		if (disponible) {
			StartCoroutine("Instantiate");
			}
	}

	IEnumerator Instantiate (){
		disponible = false;
		Instantiate (Enemigo, new Vector3 (Random.Range (-rango, rango), 4, transform.position.z), transform.rotation);
		yield return new WaitForSeconds (60f / NPM);
		disponible = true;
	}
}
