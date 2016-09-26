using UnityEngine;
using System.Collections;
using System.IO;
public class FileManager {

	private static FileManager _instance;
	public static FileManager getInstance(){
		if(_instance==null){
			_instance = new FileManager ();
		}
		return _instance;
	}
	private FileManager(){
		
	}
	public void createORwriteConfigFile(string path,string name,string info){
		File.WriteAllText(path+"//"+name,info);/* //转义*/
	}
	public void DeleteFile(string path,string name){
		string delPath = path + "//" + name;
		File.Delete (delPath);
	}
	public string LoadFile(string path,string name){
		string readPath = path + "//" + name;
		FileInfo info = new FileInfo (readPath);
		if (info.Exists) {
			string text = File.ReadAllText(readPath);
			return text;
		} else {
			return null;

		}
	}
}
