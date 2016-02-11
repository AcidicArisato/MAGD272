using UnityEngine;
using System.Collections;

public class soundTransfer : MonoBehaviour {

	//public float volume;
	//private AudioSource a;

	// Use this for initialization
	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
	}

	//void Start ()
	//{
	//	a = GetComponent<AudioSource> ();
	//}

	//void Update ()
	//{
	//	a.volume = volume;
	//}
}
