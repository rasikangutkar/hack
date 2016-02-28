using UnityEngine;
using System.Collections;

public class startDialogue : MonoBehaviour {
	//public int clickCount;
	public SpriteRenderer r;
	void Start(){
		
	
	}
		void Update(){
		if (clickCounter.clickCount == 0) {
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
