using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubTitle : MonoBehaviour {

	[SerializeField]
	Text charactor;
	[SerializeField]
	Text subTitle;
	[SerializeField]
	SubTitleScriptableObject subTitlePrefarence;
	int counter = 0;

	void Start () {
		charactor.text = "";
		subTitle.text = "";
	}
	
	
	void Update () {
		if (Input.GetKey(KeyCode.N)){
			if(subTitlePrefarence.SubTitleModels.Count > counter){
				charactor.text = subTitlePrefarence.SubTitleModels[counter].character;
				subTitle.text = subTitlePrefarence.SubTitleModels[counter].subTitle;

				counter ++;
			}
        }
	}
}
