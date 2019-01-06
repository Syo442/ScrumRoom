using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Endroll : MonoBehaviour {

	[SerializeField]
	RectTransform text;
	[SerializeField]
	GameObject videoPlayer;
	void Start () {
		StartCoroutine(DecibleVideoPlyer());
		text.DOLocalMoveY(2110.0f, 44.0f).SetRelative().SetEase(Ease.Linear);
	}

	IEnumerator DecibleVideoPlyer(){
		yield return new WaitForSeconds(36.5f);
		videoPlayer.GetComponent<RawImage>().DOFade(0.0f,0.5f);
	}
}
