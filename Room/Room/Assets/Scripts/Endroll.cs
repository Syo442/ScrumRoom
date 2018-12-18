using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Endroll : MonoBehaviour {

	[SerializeField]
	RectTransform text;
	
	void Start () {
			text.DOLocalMoveY(1200.0f, 30.0f).SetRelative();
	}
}
