using UnityEngine;
using System.Collections;

public class TinyUI : MonoBehaviour {

	public Animator animator;

	void Start () {
		BounceIn ();
	}

	void Update (){
		if (transform.localScale.x <= 0f) {
			GoToScreen("SuperKids Animation");
		}
	}

	private void BounceIn(){
		animator.SetBool ("BounceIn", true);
	}

	public void BounceOut(){
		animator.SetBool ("BounceIn", false);
		animator.SetBool ("BounceOut", true);
	}

	public void GoToScreen (string screen){
		Application.LoadLevel (screen);
	}
}
