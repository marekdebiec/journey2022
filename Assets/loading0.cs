using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading0 : MonoBehaviour {

	
	void Update () {
		if(Application.GetStreamProgressForLevel("levelName") ==1){
	    Application.LoadLevel("1111");
	}
	}
}
