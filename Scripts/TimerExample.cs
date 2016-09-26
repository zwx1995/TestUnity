using UnityEngine;
using System.Collections;

public class TimerExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (RepeatMessage (5, 1.0f, "Hello!"));//重复输出5次，每隔5秒输出一次
	}
	IEnumerator RepeatMessage(int count,float frequency,string message){
		for(int i=0;i<count;i++){
			Debug.Log (message);
			for (float timer = 0; timer < frequency; timer+=Time.deltaTime)
				yield return 0;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
