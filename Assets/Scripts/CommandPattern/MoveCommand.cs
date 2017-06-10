using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command {
	[SerializeField] private float speed = 5f;
	public override void Execute(GameObject obj){
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		obj.transform.position += new Vector3(speed * inputX, 0, speed * inputY);
	}
}
