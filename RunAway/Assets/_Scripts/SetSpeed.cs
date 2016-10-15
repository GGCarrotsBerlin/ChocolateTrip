using UnityEngine;
using System.Collections;

public class SetSpeed : MonoBehaviour {

	public SplineController splineController;

	// Use this for initialization
	void Start () {
		GameObject userData = GameObject.Find ("UserData");
		int speed = userData.GetComponent<UserData> ().speed;
		float duration = (1f / (float) speed) * 200;
		splineController.Duration = duration;
	}
}
