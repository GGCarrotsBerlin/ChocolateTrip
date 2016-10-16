using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetSummary : MonoBehaviour {

	public Text distance;
	public Text duration;

	// Use this for initialization
	void Start () {
		UserData userData = GameObject.Find ("UserData").GetComponent<UserData>();
		distance.text = (userData.speed * ((float) userData.RunDurationInSeconds/60f)).ToString("F2") + " km";
		duration.text = userData.RunDurationInSeconds.ToString() + " min";
	}
}
