using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryLife : MonoBehaviour 
{
	public float maxBattery = 100.0f;
	public float halfBattery = 50.0f;
	public float lowBattery = 25.0f;
	public Text batteryText; 

	// Use this for initialization
	void Start () 
	{
		SetBatteryText();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.X)) 
		{
			BatteryDrain ();
		}

		maxBattery -= Time.deltaTime * 2.0f;
		SetBatteryText();
	}

	void BatteryDrain()
	{
		if (maxBattery > halfBattery) 
		{
			print ("Battery Power is optimal.");
		} 
		else if (maxBattery > lowBattery) 
		{
			print ("Battery Power is sufficient.");
		}
		else
		{
			print ("Battery Power is low.");
		}
	}

	void SetBatteryText()
	{
		batteryText.text = "Battery Power: " + maxBattery.ToString ();
	}
}
