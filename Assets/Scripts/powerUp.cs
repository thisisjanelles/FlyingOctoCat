using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUp : MonoBehaviour {

    public EnergyBarAdvance enBar;

    // Use this for initialization
    void Start()
    {
        Button powerButton = GetComponent<Button>();
        powerButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        enBar.getMode();
         enBar.shrink();
    }
}