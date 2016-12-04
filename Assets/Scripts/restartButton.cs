
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Additive);
        });
    }

    // Update is called once per frame
    void Update () {
		
	}
}



