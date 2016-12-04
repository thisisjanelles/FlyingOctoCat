using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    private Transform _transform;

    // Use this for initialization
    void Start () {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update () {
       _transform.position = _transform.position + Vector3.right * 0.05f;
    }
}
