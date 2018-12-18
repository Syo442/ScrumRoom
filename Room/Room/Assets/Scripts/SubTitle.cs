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
	[SerializeField]
	AudioClip voice;
	private AudioSource audioSource;
	int counter = 0;

	void Start () {
		charactor.text = "";
		subTitle.text = "";

		StartCoroutine(SubTitleStart ());
	}
	
	
	IEnumerator SubTitleStart () {
		while(subTitlePrefarence.SubTitleModels.Count > counter){
			charactor.text = subTitlePrefarence.SubTitleModels[counter].character;
			subTitle.text = subTitlePrefarence.SubTitleModels[counter].subTitle;

			if(counter == 1){
				audioSource = gameObject.GetComponent<AudioSource>();
			audioSource.clip = voice;
			audioSource.Play ();
			}

			yield return new WaitForSeconds(subTitlePrefarence.SubTitleModels[counter].viewTime);
			counter ++;
		}

		gameObject.SetActive(false);
	}
}
