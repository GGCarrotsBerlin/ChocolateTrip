using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchToSetting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Timer ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SwitchToScene(){
		

		SceneManager.LoadScene (1);
	}

	public IEnumerator Timer(){

		yield return new WaitForSeconds (3);
		SwitchToScene ();
	}
}
