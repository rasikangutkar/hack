using UnityEngine;
using System.Collections;

public class dialog3Bob : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
		if (clickCounter.clickCount == 3) {
			//this.enabled = true;
			gameObject.GetComponent<SpriteRenderer>().enabled = true;
		} else {
			//this.enabled = false;
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
		}


	}
	void OnMouseDown(){
		clickCounter.clickCount = clickCounter.clickCount + 1;
		Debug.Log ("IHohdiu");

	}
}
