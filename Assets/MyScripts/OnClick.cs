using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {
	ItemDatabase db;
	void OnMouseDown(){
		db = GameObject.FindGameObjectWithTag ("Item Database").GetComponent<ItemDatabase>();
		db.AddItem (this.name);
		Destroy (this.gameObject);
		Debug.Log ("Added");


	}
}
