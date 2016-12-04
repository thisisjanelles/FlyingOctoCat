using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour {

    public GameObject towers; 
	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacle", 1f, 2f);
	}

    void CreateObstacle() {
        Instantiate(towers);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
