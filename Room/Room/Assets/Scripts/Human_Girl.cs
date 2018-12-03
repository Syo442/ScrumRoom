using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Girl : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("isWalk", true);
			transform.localPosition = new Vector3(transform.localPosition.x, 0.0f, transform.localPosition.z);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }

		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime, Space.World);
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);
		}

		if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jumping", true);
        }
	}
}
