using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveControl : MonoBehaviour {
    float CurrentAngle = 180F;
    float TargetAngle = 0;
    //public Transform Valve;
    public Transform Grip;
    float speed = 1f;
    float step;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void ValveRotate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TargetAngle = CurrentAngle + 90;
            if (TargetAngle >= 360) TargetAngle = TargetAngle - 360;
            //print(CurrentAngle +","+ TargetAngle);
            float angle = Mathf.LerpAngle(CurrentAngle, TargetAngle, Time.time);
            Grip.eulerAngles = new Vector3(0, 0, angle);
            //step = speed * Time.deltaTime;
            //Grip.rotation = Quaternion.Slerp(Grip.rotation, Quaternion.Euler(0, 0, TargetAngle), step);
            CurrentAngle = CurrentAngle - 90;
            if (CurrentAngle >= 360) CurrentAngle = CurrentAngle - 360;
        }
        if (Input.GetMouseButtonDown(0))
        {
            TargetAngle = CurrentAngle - 90;
            if (TargetAngle >= 360) TargetAngle = TargetAngle - 360;
            //print(CurrentAngle + "," + TargetAngle);
            float angle = Mathf.LerpAngle(CurrentAngle, TargetAngle, Time.time);
            Grip.eulerAngles = new Vector3(0, 0, angle);
            //step = speed * Time.deltaTime;
            //Grip.rotation = Quaternion.Slerp(Grip.rotation, Quaternion.Euler(0, 0, TargetAngle), step);
            CurrentAngle = CurrentAngle + 90;
            if (CurrentAngle >= 360) CurrentAngle = CurrentAngle - 360;
        }
    }
}
