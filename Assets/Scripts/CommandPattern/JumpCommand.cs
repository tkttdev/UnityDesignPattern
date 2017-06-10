using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : Command {
	[SerializeField] private float groundDist;
	private Rigidbody rigidbody;
	
	public override void Execute(GameObject obj){
		if(rigidbody == null || rigidbody.gameObject != obj){
			rigidbody = obj.GetComponent<Rigidbody>();
		}
		if(obj.transform.position.y - groundDist < Mathf.Epsilon){
			rigidbody.AddForce(new Vector3(0,300f,0));
		}
	}
}
