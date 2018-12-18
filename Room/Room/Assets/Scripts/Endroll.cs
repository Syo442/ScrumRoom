using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Endroll : MonoBehaviour {

	[SerializeField]
	RectTransform text;
	
	void Start () {
			text.DOLocalMoveY(1500.0f, 42.0f).SetRelative().SetEase(Ease.Linear);
	}
}
