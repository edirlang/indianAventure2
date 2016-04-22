using UnityEngine;
using System.Collections;

public class inicio : MonoBehaviour {
	public Texture BoxTexture;
	string username = "";
	GUIContent content;
	// Use this for initialization
	void Start () {
		content = new GUIContent("", BoxTexture, "");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI(){
		
		GUIStyle style = new GUIStyle();
		style.alignment = TextAnchor.MiddleCenter;
		GUI.Box(new Rect(0,0, Screen.width, Screen.height), BoxTexture, style);
		

		if (GUI.Button (new Rect (Screen.width / 2, 4 *(Screen.height/6) + (Screen.height/12), 100, 30), "Selecionar")) {
			Application.LoadLevel("level1");
		}

		if (GUI.Button (new Rect (Screen.width / 2- 110, 4 *(Screen.height/6) + (Screen.height/12), 100, 30), "Nuevo")) {
			Application.LoadLevel("level1");
		}
		
	}
}
