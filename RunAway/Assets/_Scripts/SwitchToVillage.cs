using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchToVillage : MonoBehaviour {

	public UserData userData;
	public InputField speedInput;
	public InputField durationInput;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Switch() {
		userData.speed = int.Parse(speedInput.text);
		userData.RunDurationInSeconds = int.Parse (durationInput.text);
		SceneManager.LoadScene (2);
	}
}
