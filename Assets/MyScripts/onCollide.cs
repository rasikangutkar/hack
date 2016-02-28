using UnityEngine;
using System.Collections;

public class onCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
		switch (collider.gameObject.tag) {
		case "Player":
			Destroy (this.gameObject);
			ScoreKeeping.score = ScoreKeeping.score + 1;
			Debug.Log ("in here");
			break;
		default:

			Debug.Log ("Collided into something else");
			break;
		}

	}
}
