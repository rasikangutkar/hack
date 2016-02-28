using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ItemDatabase : MonoBehaviour {
	List <Item> items = new List<Item>();
	bool created=false;
	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddItem(string name){
		items.Add (new Item (name));
		created = true;

	}
	void OnGUI(){
		if (created == true) {
			for (int i = 0; i < items.Count; i++) {
				GUI.DrawTexture (new Rect (i*50, 20, 100, 100), items [i].itemIcon);

			}

		}

	}

	public bool checkPresence(string name){

		for (int i = 0; i < items.Count; i++) {
			if (items [i].itemName.Equals (name)) {
				return true;

			}  
				

		}

		return false;
	}
}
