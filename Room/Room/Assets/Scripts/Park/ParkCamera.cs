using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ParkCamera : MonoBehaviour {

	[SerializeField]
	float waitTime;

	Transform carRectTran;

	void Start () {
		carRectTran = gameObject.GetComponent<Transform>();
		DOVirtual.DelayedCall (waitTime, ()=>{
			carRectTran.DOMoveX(120.0f, 25f).SetEase(Ease.Linear).SetRelative().OnComplete(() => {
				enableMeshRender();
				BirdEye();
			});
		});
	}

	void enableMeshRender(){
		GetComponent<MeshRenderer>().enabled = false;
	}

	void BirdEye(){
		carRectTran.DOLocalMove(new Vector3(-45.0f, 106.0f, 120.0f), 5.0f).SetEase(Ease.InCirc).OnComplete(() => {
			carRectTran.DOLocalMove(new Vector3(9.9f, 63.3f, -19.5f), 2.0f);
			FadeManager.Instance.LoadScene("Room",2.0f);
		});
	}
}
