using UnityEngine;
using System.Collections;

public class gotoLevel1 : MonoBehaviour {


		void Update(){
			if (clickCounter.clickCount == 5) {
			Application.LoadLevel ("level1");
			} 
		



	}
}
