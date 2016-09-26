using UnityEngine;
using System.Collections;

public class Person : MonoBehaviour {
	public string Name{
		get{ return PlayerPrefs.GetString ("Third");}
		set{ PlayerPrefs.SetString ("Third", value);
			PlayerPrefs.Save ();
		}
	}
}
