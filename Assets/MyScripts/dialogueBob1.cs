using UnityEngine;
using System.Collections;

public class dialogueBob1 : MonoBehaviour {
	SpriteRenderer r;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer>().enabled = false;
	}
	
	void Update(){
		if (clickCounter.clickCount == 1) {
			gameObject.GetComponent<SpriteRenderer>().enabled = true;
		} else {
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
		}


	}


	void OnMouseDown(){
		clickCounter.clickCount = clickCounter.clickCount + 1;
		Debug.Log ("ddsfu");
	}



}
