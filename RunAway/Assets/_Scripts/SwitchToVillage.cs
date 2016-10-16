using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchToVillage : MonoBehaviour {

	public UserData userData;
	public InputField speedInput;
	public InputField durationInput;

	public GameObject loadingScreen;
	public Text loadingText;
	public Text progress;

	public void Switch() {
		userData.speed = int.Parse(speedInput.text);
		userData.RunDurationInSeconds = int.Parse (durationInput.text);
		StartCoroutine (ShowLoadingScreen ());
	}

	private IEnumerator ShowLoadingScreen() {
		AsyncOperation async = SceneManager.LoadSceneAsync (2);
		loadingScreen.SetActive (true);
		progress.text = async.progress.ToString();
		while (!async.isDone) {	
			progress.text = async.progress.ToString("F2") + "%";
			if (async.progress > 0.89f)
				Screen.orientation = ScreenOrientation.LandscapeLeft;
			yield return null;
		}
	}
}
