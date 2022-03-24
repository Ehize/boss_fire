using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{ 
    [SerializeField]
    private Slider slider;

    [SerializeField]
    private HealthbarBehaviour healthbar;


    // Start is called before the first frame update
    private void Start()
    {
        ChangeSliderValue(healthbar.health);
    }
    
    private void OnEnable() 
    {
        healthbar.healthChangeEvent.AddListener(ChangeSliderValue);
    }

    private void OnDisable() 
    {
        healthbar.healthChangeEvent.RemoveListener(ChangeSliderValue);
    }

    public void ChangeSliderValue(int amount) {
        slider.value = ConvertIntToFloatDecimal(amount);
    }

    private float ConvertIntToFloatDecimal(int amount) {
        return (float)amount / 100;
    }
}
