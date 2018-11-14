using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarMoveRightToLeft : MonoBehaviour {

	[SerializeField]
	float waitTime;

	void Start () {
		Transform carRectTran = gameObject.GetComponent<Transform>();
		DOVirtual.DelayedCall (waitTime, ()=>{
			carRectTran.DOMoveX(180.0f, 10f).SetEase(Ease.Linear).SetLoops(-1).SetRelative();
		});
	}
}
