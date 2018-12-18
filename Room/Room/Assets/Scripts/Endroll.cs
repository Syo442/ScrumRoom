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
			text.DOLocalMoveY(1560.0f, 42.0f).SetRelative().SetEase(Ease.Linear).OnComplete(() => {
				videoPlayer.GetComponent<RawImage>().DOFade(0.0f,0.5f);
			});
	}
}
