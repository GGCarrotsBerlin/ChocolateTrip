using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetSummary : MonoBehaviour {

	public Text distance;
	public Text duration;

	// Use this for initialization
	void Start () {
		UserData userData = GameObject.Find ("UserData").GetComponent<UserData>();
		distance.text = ((float) userData.speed * ((float) userData.RunDurationInSeconds/60f)).ToString() + " km";
		duration.text = userData.RunDurationInSeconds.ToString() + " min";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
