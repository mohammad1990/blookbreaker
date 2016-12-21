using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null; 
	// Use this for initialization
	void  Awake() 
	{
		print ("the awake method is call");
		if (instance != null) {
			Destroy (gameObject);
			print ("the game object is distroy");
		}
		{
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);	
		}
	}
	void Start () {
		Debug.Log("music player start "+ GetInstanceID());


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
