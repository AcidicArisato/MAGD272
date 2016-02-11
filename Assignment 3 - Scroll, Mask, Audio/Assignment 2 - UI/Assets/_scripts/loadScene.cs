using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

	public string firstSceneName;
	public string secondSceneName;
	public string thirdSceneName;
	public string fourthSceneName;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	// Function for loading first scene
	public void loadFirstScene ()
	{
		SceneManager.LoadScene (firstSceneName, LoadSceneMode.Single);
	}

	public void loadSecondScene ()
	{
		SceneManager.LoadScene (secondSceneName, LoadSceneMode.Single);
	}

	public void loadThirdScene ()
	{
		SceneManager.LoadScene (thirdSceneName, LoadSceneMode.Single);
	}

	public void loadFourthScene ()
	{
		SceneManager.LoadScene (fourthSceneName, LoadSceneMode.Single);
	}


}
