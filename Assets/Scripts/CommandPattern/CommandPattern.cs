using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPattern : MonoBehaviour {

	[SerializeField] private InputHandler inputHandler;
	[SerializeField] private GameObject player;
	
	void Update () {
		Command cmd = inputHandler.HandleInput();
		if(cmd != null){
			cmd.Execute(player);
		}
	}
}
