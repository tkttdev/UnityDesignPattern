﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField] private InputHandler inputHandler;
	
	void Update () {
		Command cmd = inputHandler.HandleInput();
		if(cmd != null){
			cmd.Execute(gameObject);
		}
	}
}
