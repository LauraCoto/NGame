using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour {
	public float velocidad  =10f;
	public float maximo_x= 19f;
	public float maximo_y= 10f;
	public GameObject Lanzador_L;
	public GameObject Lanzador_R;
	public GameObject bala;

	void Update () {
		//Movimiento Horizontal
		if (Input.GetAxis("Horizontal") != 0 && transform.position.x < maximo_x && transform.position.x > -	maximo_x) {
			transform.Translate(new Vector3(1,0,0)*velocidad*Time.deltaTime*Input.GetAxis("Horizontal"));
		}
		if (transform.position.x >= maximo_x) {
			transform.Translate(new Vector3(-maximo_x-0.01f,0,0)*Time.deltaTime);
		}
		if (transform.position.x <= -maximo_x) {
			transform.Translate(new Vector3(maximo_x+0.01f,0,0)*Time.deltaTime);
		}

		//Movimiento Vertical
		if (Input.GetAxis("Vertical") != 0 && transform.position.z < maximo_y && transform.position.z > -maximo_y) {
			transform.Translate(new Vector3(0,0,1)*velocidad*Time.deltaTime*Input.GetAxis("Vertical"));
		}
		if (transform.position.z >= maximo_y) {
			transform.Translate(new Vector3(0,0,-maximo_y-0.01f)*Time.deltaTime);
		}
		if (transform.position.z <= -maximo_y) {
			transform.Translate(new Vector3(0,0,maximo_y+0.01f)*Time.deltaTime);
		}

		//Lanzamiento Proyectiles
		if (Input.GetButtonDown ("Jump")) {
			Instantiate(bala,new Vector3 (Lanzador_L.transform.position.x,Lanzador_L.transform.position.y,Lanzador_L.transform.position.z),transform.rotation);
			Instantiate(bala,new Vector3 (Lanzador_R.transform.position.x,Lanzador_R.transform.position.y,Lanzador_R.transform.position.z),transform.rotation);

		}

	}
}
