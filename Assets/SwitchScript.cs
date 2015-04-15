using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour {

	Animator anim;
	public bool sticks;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerStay2D()
	{
		anim.SetBool ("goDown", true);
	}

	void OnTriggerExit2D()
	{
		if(sticks)
			return;

		anim.SetBool ("goDown", false);
	}

}
