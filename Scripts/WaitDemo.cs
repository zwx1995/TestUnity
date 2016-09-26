using UnityEngine;
using System.Collections;

public class WaitDemo : MonoBehaviour {

	void Start () {
		StartCoroutine (SaySomeThings ());
	}
	
	IEnumerator SaySomeThings(){
		Debug.Log ("started");
		yield return new WaitForSeconds (1);
		Debug.Log ("1 s");
		yield return StartCoroutine (Wait (2.5f));
		Debug.Log ("2.5 s");
	}
	IEnumerator Wait(float duration){
		for(float timer=0;timer<duration;timer+=Time.deltaTime){
			yield return 0;
		}
	}
	void Update () {
	
	}
}
