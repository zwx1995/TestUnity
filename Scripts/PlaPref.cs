using UnityEngine;
using System.Collections;

public class PlaPref : MonoBehaviour {
	void Awake(){
		PlayerPrefs.SetInt ("FIRST", 20);
		PlayerPrefs.SetFloat ("SECOND", 2.06f);
		PlayerPrefs.SetString ("TRIRD", "Hello");
		PlayerPrefs.SetString ("URL", WWW.EscapeURL ("www.baidu.com"));
		if(PlayerPrefs.HasKey("URL")){
			PlayerPrefs.DeleteKey ("URL");
		}
//		Debug.Log (PlayerPrefs.GetInt ("FIRST"));
//		Debug.Log (PlayerPrefs.GetFloat ("SECOND"));
//		Debug.Log (PlayerPrefs.GetString ("THIRD"));
		PlayerPrefs.Save ();
		//Unityt特殊文件夹(Resourxes,Editor,Plungix,StreamingAssets)
//		Debug.Log(Application.persistentDataPath);
//		Debug.Log (Application.streamingAssetsPath);
//		Debug.Log (Application.dataPath);
	}
	/*
		序列化就是把一个对象保存到一个文件或数据库字段中去
		反序列化就是在适当的时候把文件再转换成原来的对象使用
	*/
	void Start () {
	
	}
	

	void Update () {
	
	}
}
