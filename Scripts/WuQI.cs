using UnityEngine;
using System.Collections;
using System.IO;
using LitJson;
public class WuQI : MonoBehaviour {
	void Start () {
		testFileCreate ();
		//ParseArray();
	}
	void testFileCreate(){
		string path = Application.dataPath;
		string FileName="zhuangbei.json";
		string jsonStr = FileManager.getInstance ().LoadFile(path,FileName);
		JsonData newData = JsonMapper.ToObject (jsonStr);
		JsonData jd = newData ["Equipts"];
		Debug.Log (jd.Count);
		Debug.Log (jd [5] ["name"]);
	}
	void ParseArray(){
		string str = "{'Equipts':[" +
			"{'id':'1160010[1]','name':'青龙偃月刀','price':2800,'aggressivity':30,'HP':0,'Armor':0}," +
			"{'id':'1160015[1]','name':'环首刀','price':1500,'aggressivity':10,'HP':0,'Armor':0}," +
			"{'id':'1160020[1]','name':'冰霜雪剑','price':3600,'aggressivity':30,'HP':0,'Armor':0}," +
			"{'id':'1130012[1]','name':'狂徒铠甲','price':2500,'aggressivity':0,'HP':1000,'Armor':20}," +
			"{'id':'1130015[1]','name':'日炎斗篷','price':2200,'aggressivity':0,'HP':500,'Armor':30}," +
			"{'id':'1140006[1]','name':'无敌耐操裤','price':3200,'aggressivity':0,'HP':0,'Armor':100}" +
			"]}";
		JsonData jd = JsonMapper.ToObject (str);
		JsonData equipts=jd["Equipts"];
		Debug.Log (equipts.Count);
		Debug.Log (equipts [0] ["id"]);
	}
}
