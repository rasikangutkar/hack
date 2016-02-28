using UnityEngine;
using System.Collections;
[System.Serializable]
public class Item {
	public string itemName;
	public Texture2D itemIcon;
	// Use this for initialization
	public Item(){
	}
	public Item(string name){
		itemName = name;
		itemIcon = Resources.Load<Texture2D>(name);

	}
}
