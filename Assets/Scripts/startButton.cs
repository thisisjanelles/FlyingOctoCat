using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class startButton : MonoBehaviour {
	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(()=>
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
        });
    }
	
	// Update is called once per frame
	void Update () {
	}
}
