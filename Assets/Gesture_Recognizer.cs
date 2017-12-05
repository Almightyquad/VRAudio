using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gesture_Recognizer : MonoBehaviour {

    bool rightControllerActive = false;
    bool leftControllerActive = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        List<GameObject> touchingObjects = this.GetComponent<VRTK.VRTK_InteractableObject>().GetTouchingObjects();
    
        foreach(GameObject g in touchingObjects)
        {
            if(g.name == "RightController")
            {
                rightControllerActive = true;
            }
            if(g.name == "LeftController")
            {
                leftControllerActive = true;
            }
        }
	}
}
