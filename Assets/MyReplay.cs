using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MyKeyFrame myKeyFrame = new MyKeyFrame(Time.timeSinceLevelLoad, transform.position, transform.rotation);
    
	}
}

public struct MyKeyFrame {

    public MyKeyFrame(float time, Vector3 posision, Quaternion rotasion)
    {
        Debug.Log("time: " + time + "....." + "pos: " + posision + "....." + "rot: " + rotasion + "/n");
    }
}