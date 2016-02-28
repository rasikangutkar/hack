using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {
	ItemDatabase db;
	bool stdioManualPresence;
	bool printerPresence ;
	// Use this for initialization
	void OnTriggerEnter(Collider collider){
		switch (collider.gameObject.tag) {
		case "Player":
			db = GameObject.FindGameObjectWithTag ("Item Database").GetComponent<ItemDatabase> ();
			 printerPresence = db.checkPresence ("Printer");
			stdioManualPresence= db.checkPresence ("stdioManual");
			if (printerPresence && stdioManualPresence) {
				Application.LoadLevel ("level2");
				Debug.Log ("in here");

			} else {
				Debug .Log("You need to collect the printer and stdio Manual to get into the control room");
			
			}
			break;
		default:

			Debug.Log ("Collided into something else");
			break;
		}

	}
}
