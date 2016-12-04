using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OctoCatControl : MonoBehaviour {

	private Rigidbody2D _rigidBody;
    private Transform _transform;
	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody2D> ();
        _transform = GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			_rigidBody.velocity = Vector2.up * 4 + Vector2.right * 0.5f;
		}

        if(_transform.position.x < -15 || _transform.position.y < -15 || _transform.position.y > 15)
        {
            SceneManager.LoadScene("gameOver");
        }
	}
}
