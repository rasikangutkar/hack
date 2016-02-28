using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,20 * Time.deltaTime,  0);
	}

	void OnTriggerEnter(Collider collider){
		switch (collider.gameObject.tag) {
		case "Player":
			Destroy (this.gameObject);
			break;
		default:

			Debug.Log ("Collided into something else");
			break;
		}

	}
}
