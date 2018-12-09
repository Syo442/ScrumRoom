using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RoomAnimeController : MonoBehaviour {

	[SerializeField]
	Human_Girl human_Girl;
	[SerializeField]
	RectTransform image1;
	[SerializeField]
	RectTransform image2;
	[SerializeField]
	RectTransform image3;
	[SerializeField]
	RawImage video;
	bool imageViewFlag;
	bool videoViewFlag;

	void Start () {
		image1.localScale = Vector3.zero;
		image2.localScale = Vector3.zero;
		image3.localScale = Vector3.zero;
		imageViewFlag = false;
		videoViewFlag = false;
		StartCoroutine(AnimeController());
	}
	
	IEnumerator AnimeController(){
		yield return new WaitForSeconds(10.0f);
		human_Girl.isTurnRight = true;
		yield return new WaitForSeconds(0.2f);
		human_Girl.isTurnRight = false;

		human_Girl.iswalk = true;

		yield return new WaitForSeconds(5.0f);

		human_Girl.iswalk = false;
		human_Girl.isJump = true;

		yield return new WaitForSeconds(0.1f);

		human_Girl.isJump = false;
	}

	public void ViewImage(){
		if(imageViewFlag){
			image1.DOScale(1.0f, 1.0f);
			image2.DOScale(1.0f, 1.0f);
			image2.DOScale(1.0f, 1.0f);

			imageViewFlag = true;
		}else{
			image1.DOScale(0.0f, 1.0f);
			image2.DOScale(0.0f, 1.0f);
			image2.DOScale(0.0f, 1.0f);

			imageViewFlag = false;
		}
	}

	public void ViewVideo(){

	}
}