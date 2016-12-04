using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBarAdvance : MonoBehaviour {

    private Image _energyBar;
    
    void Start()
    {
        _energyBar = GetComponent<Image>();
        _energyBar.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _energyBar.fillAmount += 0.0001f;
     }

    
    public void shrink()
    {
        if (_energyBar.fillAmount > 0.999f) {
            _energyBar.fillAmount = 0;
        } else if (_energyBar.fillAmount > 0.666f) {
            _energyBar.fillAmount -= 0.666f;
        } else if (_energyBar.fillAmount > 0.333f) {
            _energyBar.fillAmount -= 0.333f;
        }
    }
}