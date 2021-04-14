using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProtectTimer : MonoBehaviour
{
	public ConvertToInfector convertToInfector;
	public Slider slider;
	

	TextMeshProUGUI text;

	void Start()
	{
		text = GetComponent<TextMeshProUGUI>();
		slider = GetComponent<Slider>();
		//slider.maxValue = myTimer;
		//slider.minValue = 0;
	}

	void Update()
	{
		float myTimer = convertToInfector.protectTime;
		slider.value = myTimer;
		text.text = (myTimer).ToString("00");


	}
}
