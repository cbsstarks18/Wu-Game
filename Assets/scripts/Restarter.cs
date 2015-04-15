﻿using UnityEngine;
using System.Collections;
//restarts game when died 
public class Restarter : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Player")
			Application.LoadLevel(Application.loadedLevelName);
	}
}
