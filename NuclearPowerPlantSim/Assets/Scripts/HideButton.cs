using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour {
    public Transform form;
    public Animator animator;

    // Use this for initialization
    void Start () {
        /*obj = GameObject.Find("unitychan");
        anim = obj.GetComponent<Animator>();*/
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("isHide", !animator.GetBool("isHide"));
        }
    }
    public void Pressd()
    {
        animator.SetBool("isHide", !animator.GetBool("isHide"));
    }
}
