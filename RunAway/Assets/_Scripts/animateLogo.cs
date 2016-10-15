using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class animateLogo : MonoBehaviour {

	public Image logo;

	// Use this for initialization
	void Start () {
		FadeIn (logo.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void FadeIn(GameObject gameObject) {

		iTween.ValueTo (gameObject, iTween.Hash (
			"from", 0f, "to", 1f,
			"time", 3f, "easetype", "linear",
			"onupdate", "setAlpha"));

			}

}
