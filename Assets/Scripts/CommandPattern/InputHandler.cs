using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour{
	[SerializeField] private Command buttonArrow;
	[SerializeField] private Command buttonSpace;

	public Command HandleInput(){
		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow)){
			return buttonArrow;
		} else if(Input.GetKeyDown(KeyCode.Space)){
			return buttonSpace;
		} 

		return null;
	}
}
