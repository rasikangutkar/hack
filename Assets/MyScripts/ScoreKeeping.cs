using UnityEngine;
using System.Collections;

public class ScoreKeeping : MonoBehaviour {
	public static int score=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		GUI.Label (new Rect(0,0,100,100),"Score: "+score);
		Debug.Log ("in here");


	}

}
