﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButtonScript : MonoBehaviour {
	[SerializeField]
	GameObject panel;

	// Use this for initialization
	void Start () {
	}

	public void HelpButtonPressed() {
		panel.SetActive (true);
	}
}
