using UnityEngine;
using System.Collections;

public class ExampleBehaviourScript : MonoBehaviour {

	int bilangan = 8;

	int increament(int bil){ return bilangan = bilangan + 2; }

	void Awake (){ Debug.Log("Awake called."); }

	void Start (){ Debug.Log("Start called."); }

	void FixedUpdate(){
		bilangan = increament (bilangan);
		Debug.Log ("Bilangan : " + bilangan);
		Debug.Log ("Fixed update time : " + Time.deltaTime);
	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("Update time : " + Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.R))
		{
			GetComponent<Renderer> ().material.color = Color.red;
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			GetComponent<Renderer>().material.color = Color.green;
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
