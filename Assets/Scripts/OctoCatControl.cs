using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctoCatControl : MonoBehaviour {

	private Rigidbody2D _rigidBody;

	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			_rigidBody.velocity = Vector2.up * 4;
		}
	}
}
