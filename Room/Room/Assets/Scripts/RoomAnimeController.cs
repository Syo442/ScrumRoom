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

	// 皆さんこんにちわ
	// ここは多摩1ビル4階フロアです。
	// 今日は皆さんにこのフロアと業務について紹介します。
	// ここでは、小ゼミ〜高ゼミまでのデジタルアプリ開発を行っています(チャレンジタッチやiPhoneのが画像だす)
	// このスペースはスクラムルーム
	// スクラムルームでは、文字通りスクラム開発が行われています。
	// 部屋の壁は全てホワイトボードになっており、
	// 文字を書いたり付箋を貼ったりと効率化のための機能が備わっています。
	// 事業部の方とのコミュニケーションの場にもなっており、
	// 開発者と事業部が一丸となった高速開発を行っています。


	// 今までに開発を行った一例を紹介します。
	// こちらは、小ゼミ◯年生が対象の「怪盗大追跡」というアプリで、
	// インフォシェルメンバーの糸井さんが単独で開発を行ったものです。
	// こちらのアプリの総開発期間は約3ヶ月となっており、
	// 途中での仕様追加やデザイン変更にも柔軟に対応ができデジタルアプリ内製の強みを発揮できた案件となっています。

	// 各ゼミごとに別れ開発者はここで開発を行っています。

	// こっちは、運用チームやPMの方々が業務をしています。

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