using UnityEngine;
using System.Collections;

public class UserData : MonoBehaviour {
	
	public int RunDurationInSeconds;
	public int speed;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

}
