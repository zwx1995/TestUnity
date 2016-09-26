using UnityEngine;
using System.Collections;
using System.Xml;
public class XMLParse : MonoBehaviour {

	public string xmlFileName="/Test.xml";
	private string xmlFileParth = string.Empty;
	void Awake(){
		xmlFileParth = Application.streamingAssetsPath+ xmlFileName;
		XMLParserFunc ();
	}
	void Start () {
	
	}
	/*成功源于不懈的努力，加油*/
	// Update is called once per frame
	void Update () {
	
	}
	void XMLParserFunc(){
		//DOM解析  //SAX解析
		XmlDocument doc = new XmlDocument ();
		doc.Load (xmlFileParth);
		XmlNode root = doc.SelectSingleNode ("plist");//XmlNode表示XML文档中的单个节点。

		foreach(XmlElement child in root){
			if(child.Name.Equals("dict")){
				foreach(XmlElement derived in child){
					if(derived.Name.Equals("array")){
						// 1.Add Element
						XmlElement ele = doc.CreateElement ("myString");
						ele.InnerText="you are beautiful";
						derived.AppendChild (ele);
						// appendChild(node):方法在指定元素节点的最后一个子节点之后添加节点,该方法返回新的子节点。

						//2.Change Element
//						foreach(XmlElement groundSon in derived){
//							Debug.Log (groundSon.Name);
//							Debug.Log (groundSon.InnerText);
//							groundSon.InnerText = "修改后的内容";
//						}

						//3.Delete Element
//						derived.RemoveChild(derived.LastChild);
					}
				}

			}
			doc.Save (xmlFileParth);
		}
	}
//	public static string GetDataPath(){
//		if(Application.platform==RuntimePlatform){
//			string path = Application.dataPath.Substring (0, Application.dataPath.Length - 5);
//		}
//	}
}
