using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacle : MonoBehaviour {

    private Transform towerParent;
    public GameObject towers; 
	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacle", 1f, 2f);
        towerParent = GameObject.FindGameObjectWithTag("towerParent").GetComponent<Transform>();

    }

    void CreateObstacle() {
        var instantiatedTower = (GameObject)Instantiate(towers);
        instantiatedTower.GetComponent<Transform>().parent = towerParent;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
