using UnityEngine;
using System.Collections;

public class dialog4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
		if (clickCounter.clickCount == 4) {
			//this.enabled = true;
			gameObject.GetComponent<SpriteRenderer>().enabled = true;
		} else {
			//this.enabled = false;
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
		}

		if (clickCounter.clickCount == 5) {
			Application.LoadLevel ("level1");
		}
	}
	void OnMouseDown(){
		clickCounter.clickCount = clickCounter.clickCount + 1;
		Debug.Log ("IHohdiu");

	}
}
