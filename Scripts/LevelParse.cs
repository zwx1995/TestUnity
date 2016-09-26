using UnityEngine;
using System.Collections.Generic;
using System.Xml;
public class LevelParse : MonoBehaviour {

	public string xmlFileName="/Level.xml";
	private string xmlFileParth = string.Empty;
	List<Level> levelList=new List<Level>();
	void Start () {
		xmlFileParth = Application.streamingAssetsPath + xmlFileName;
		ParseLevel ();
	}
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			foreach(Level ipad in levelList){
				Debug.Log (ipad.name);
				Debug.Log (ipad.star);
				Debug.Log (ipad.unlock);
			}
		}
	}
	void ParseLevel(){
		XmlDocument doc = new XmlDocument ();
		doc.Load (xmlFileParth);
		XmlNode root = doc.SelectSingleNode ("Levels");
		XmlNode node = root.FirstChild;
		while(node!=null){
			//可以进行解析操作
			node=node.NextSibling;//nextSibling 属性可返回某个元素之后紧跟的元素（处于同一树层级中）。
			                      //如果无此节点，则属性返回 null。与其相反的是previousSibling
			print ("sss");
		}


//		foreach(XmlElement ipad in root){
//			Level currentLevel = new Level ();
//			foreach(XmlElement pro in ipad){
//				if (pro.Name == "Name") {
//					currentLevel.name = pro.InnerText;
//				} else if (pro.Name == "Star") {
//					currentLevel.star = int.Parse (pro.InnerText);
//				} else {
//					currentLevel.unlock = int.Parse (pro.InnerText);
//				}
//			}
//			levelList.Add (currentLevel);
//		}
	}
	public static void changeLevel(int index,int star){
	
	}
}
