using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBarAdvance : MonoBehaviour {

    private Image _energyBar;
    
    void Start()
    {
        _energyBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _energyBar.fillAmount = Time.time * 0.05f;
     }

    float getFillAmount()
    {
        return _energyBar.fillAmount;
    }

    void shrink()
    {
        if (_energyBar.fillAmount > 1/3) {
            _energyBar.fillAmount -= 1 / 3;
        } else if (_energyBar.fillAmount > 2 / 3) {
            _energyBar.fillAmount -= 2 / 3;
        } else if (_energyBar.fillAmount > 0.999f) {
            _energyBar.fillAmount = 0;
        }
    }
}