using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField] private Command buttonArrow;
	[SerializeField] private Command buttonSpace;

	void Start () {
		
	}
	
	void Update () {
		Command cmd = InputHandler();
		if(cmd != null){
			cmd.Execute(gameObject);
		}
	}

	private Command InputHandler(){
		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow)){
			return buttonArrow;
		} else if(Input.GetKeyDown(KeyCode.Space)){
			return buttonSpace;
		} 

		return null;
	}
}
