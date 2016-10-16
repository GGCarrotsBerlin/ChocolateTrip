using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cheering : MonoBehaviour {

	private float timePassed = 0;
	private int runDuration;
	public GvrAudioSource applause;
	public SplineController splineController;

	private bool applauseStarted = false;
	private 

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;

		GameObject userDataObj = GameObject.Find ("UserData");
		UserData userData = userDataObj.GetComponent<UserData> ();
		runDuration = userData.RunDurationInSeconds;
	}
	
	// Update is called once per frame
	void Update () {
		timePassed += Time.deltaTime;
		if (timePassed > runDuration && !applauseStarted) {
			applauseStarted = true;
			splineController.enabled = false;
			applause.Play ();
			StartCoroutine (SwitchScenes (applause.clip.length));
		}

	}

	private IEnumerator SwitchScenes(float seconds) {
		int secs = (int)seconds;
		yield return new WaitForSeconds (secs);
		SceneManager.LoadScene (3);
	}
}
