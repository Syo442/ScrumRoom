using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Girl : MonoBehaviour {

	Animator anim;

	Vector3 touchStartPos;
	Vector3 touchEndPos;
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

		///タッチ対応
		if (Input.GetKeyDown(KeyCode.Mouse0)){
			anim.SetBool("isWalk", true);
			touchStartPos = new Vector3(Input.mousePosition.x,
										Input.mousePosition.y,
										Input.mousePosition.z);
		}

		if (Input.GetKeyUp(KeyCode.Mouse0)){
			anim.SetBool("isWalk", false);
			touchEndPos = new Vector3(Input.mousePosition.x,
									Input.mousePosition.y,
									Input.mousePosition.z);
			GetDirection();
		}
	}

	void GetDirection(){
		float directionX = touchEndPos.x - touchStartPos.x;
		float directionY = touchEndPos.y - touchStartPos.y;

		if (Mathf.Abs(directionY) < Mathf.Abs(directionX)){
			if (30 < directionX){
				//右向きにフリック
				transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime, Space.World);
			}else if (-30 > directionX){
				//左向きにフリック
				transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);
			}
		}else if (Mathf.Abs(directionX)<Mathf.Abs(directionY)){
            if (30 < directionY){
                //上向きにフリック
                anim.SetBool("Jumping", true);
            }else if (-30 > directionY){
                //下向きのフリック
                
            }
    	}else{
                //タッチを検出
                
        }
	}
}
