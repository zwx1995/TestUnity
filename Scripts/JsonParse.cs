using UnityEngine;
using System.Collections;
using LitJson;
using System.IO;
public class JsonParse : MonoBehaviour {
	void Start () {
		//createJsonData ();
		//parseArray ();
		//testFileCreate();
		ParsePlayer();
	}
	void Update () {
	
	}
	void ParsePlayer(){
		Player player = new Player ();
		player.age = 20;
		player.sex="male";
		player.Name="wangkai";
		string json = JsonMapper.ToJson (player);
		Debug.Log (json);

		Player player2 = JsonMapper.ToObject<Player> (json);
		Debug.Log (player2.Name);
	}
	void createJsonData(){
		/*1:Normal Json Object*/
		JsonData data = new JsonData ();
		data ["name"] = "zhangsan";
		data ["age"] = 20;
		data["sex"]="male";
		string jsonStr = data.ToJson ();
		Debug.Log (jsonStr);

		/*2:QianTao Json Object*/
		JsonData data1 = new JsonData ();
		data1["name"]="lisi";
		data1 ["options"] = new JsonData ();
		data1 ["options"] ["age"] = 20;
		data1["options"]["sex"]="male";
		string jsonStr1 = data1.ToJson ();
		Debug.Log (jsonStr1);


		/*Parse the json directly*/
		Debug.LogFormat("{0},{1}",data1["name"],data1["options"]["age"]);


		/*To convert the string to JsonObject*/
		JsonData newData = JsonMapper.ToObject (jsonStr1);
		Debug.LogFormat ("{0},{1}",newData ["name"], newData["options"] ["sex"]);
	}
	void parseArray(){
		string str = "{'name':'taobao','id':10,'items':" +
		            "[{'itemid':1001,'itemname':'dtao'}," +
		            "{'itemid':1002,'itemname':'test_2'}]}";
		//json解析
		JsonData jd=JsonMapper.ToObject(str);
		Debug.Log ("name=" + jd ["name"]);
		Debug.Log ("id=" + jd ["id"]);
		JsonData jdItems = jd ["items"];
		Debug.Log (jdItems.Count);
		for(int i=0;i<jdItems.Count;i++){
			Debug.Log ("itemid" +"  " +jdItems [i] ["itemid"]);
			Debug.Log ("itemname" + "  "+jdItems [i] ["itemname"]);
		}
		Debug.Log ("item is or not array,it's"+jdItems.IsArray);
	}
	void testFileCreate(){
		string path = Application.dataPath;
		string FileName="Demo1.json";
		string jsonStr = FileManager.getInstance ().LoadFile(path,FileName);
		JsonData newData = JsonMapper.ToObject (jsonStr);
		Debug.LogFormat ("{0},{1}", newData ["name"], newData ["id"]);
	}
}
