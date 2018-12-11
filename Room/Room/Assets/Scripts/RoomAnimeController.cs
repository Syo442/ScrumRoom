using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
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
	RectTransform video;
	[SerializeField]
	VideoPlayer mPlayer;
	bool imageViewFlag;
	bool videoViewFlag;
	int imageCounter;

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
	//そのほかにもこのフロアは緑と木目、白が基調色となっており
	//集中して業務が行える工夫がいたるところにあります。


	// 今までに開発を行った一例を紹介します。
	// こちらは、小ゼミ◯年生が対象の「英語で怪盗大追跡」というアプリです。
	// このアプリは、インフォシェルメンバーの糸井さんが単独で開発を行ったものです。
	// こちらのアプリの総開発期間は約3ヶ月となっており、
	// 途中での仕様追加やデザイン変更にも柔軟に対応ができ
	//デジタルアプリ内製の強みを発揮できた案件となっています。

	// このように私たち、デジタル開発メンバーは日々、
	// 最新技術や効率化、事業部に寄り添った開発により
	// 子供達の学力向上や未来に貢献しています。

	void Start () {
		image1.localScale = Vector3.zero;
		image2.localScale = Vector3.zero;
		image3.localScale = Vector3.zero;
		video.localScale = Vector3.zero;
		imageViewFlag = false;
		videoViewFlag = false;
		imageCounter = 0;
		StartCoroutine(AnimeController());
	}
	
	IEnumerator AnimeController(){
		yield return new WaitForSeconds(9.0f);

		human_Girl.isTurnRight = true;
		yield return new WaitForSeconds(0.2f);
		human_Girl.isTurnRight = false;

		human_Girl.iswalk = true;
		yield return new WaitForSeconds(5.0f);
		human_Girl.iswalk = false;

		//待機
		yield return new WaitForSeconds(8.5f);

		human_Girl.isTurnRight = true;
		yield return new WaitForSeconds(0.85f);
		human_Girl.isTurnRight = false;

		human_Girl.iswalk = true;
		yield return new WaitForSeconds(6.0f);
		human_Girl.iswalk = false;

		human_Girl.isTurnLeft = true;
		yield return new WaitForSeconds(1.0f);
		human_Girl.isTurnLeft = false;

		//待機
		yield return new WaitForSeconds(22.0f);

		human_Girl.isTurnRight = true;
		yield return new WaitForSeconds(1.00f);
		human_Girl.isTurnRight = false;

		human_Girl.iswalk = true;
		yield return new WaitForSeconds(11.5f);
		human_Girl.iswalk = false;


		human_Girl.isTurnLeft = true;
		yield return new WaitForSeconds(1.55f);
		human_Girl.isTurnLeft = false;

		//待機
		yield return new WaitForSeconds(40.0f);

		human_Girl.isTurnRight = true;
		yield return new WaitForSeconds(0.55f);
		human_Girl.isTurnRight = false;


		human_Girl.iswalk = true;
		yield return new WaitForSeconds(2.0f);
		human_Girl.iswalk = false;

		human_Girl.isTurnRight = true;
		yield return new WaitForSeconds(0.9f);
		human_Girl.isTurnRight = false;


		// human_Girl.isJump = true;
		// yield return new WaitForSeconds(0.1f);
		// human_Girl.isJump = false;
	}

	public void ViewImage(){
		if(!imageViewFlag){
			if(imageCounter == 0){
				image1.DOScale(1.0f, 1.0f);
			}else if(imageCounter == 1){
				image2.DOScale(1.0f, 1.0f);
				image3.DOScale(1.0f, 1.0f);
			}
			imageViewFlag = true;
		}else{
			if(imageCounter == 0){
				image1.DOScale(0.0f, 1.0f);
			}else if(imageCounter == 1){
				image2.DOScale(0.0f, 1.0f);
				image3.DOScale(0.0f, 1.0f);
			}

			imageViewFlag = false;
			imageCounter ++;
		}
	}

	public void ViewVideo(){
		if(!videoViewFlag){
			video.DOScale(1.0f, 1.0f).OnComplete(() => {
				mPlayer.Play();
			});

			videoViewFlag = true;
		}else{
			video.DOScale(0.0f, 1.0f).OnComplete(() => {
				mPlayer.Pause();
			});

			videoViewFlag = false;
		}
	}
}