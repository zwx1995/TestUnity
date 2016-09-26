using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	void Start () {
		StartCoroutine (member ("message"));
		//StartCoroutine ("member");//这种方式不能带参数
	}
	IEnumerator member(string msg){
		for(float timer=3;timer>=0;timer-=Time.deltaTime){
			yield return 0;//从这里暂停，从这里开始

		}
		Debug.Log(msg);
	}
	void Update () {
	
	}
}
