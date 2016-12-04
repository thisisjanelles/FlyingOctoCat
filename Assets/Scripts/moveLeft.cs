using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour {

    private RectTransform _transform;

	// Use this for initialization
	void Start () {
        _transform = GetComponent<RectTransform>();

    }
	
	// Update is called once per frame
	void Update () {
        _transform.position = _transform.position - Vector3.right*0.05f;
        if (_transform.position.x < -20)
        {
            _transform.localPosition = _transform.localPosition + new Vector3(_transform.rect.width * 3f, 0, 0);
        }
    }
}
