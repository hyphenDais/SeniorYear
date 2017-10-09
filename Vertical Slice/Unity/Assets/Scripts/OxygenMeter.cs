using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenMeter : MonoBehaviour {

	public float maxAir = 100.0f;
	public float midAir = 60.0f;
	public float lowAir = 20.0f;
	public Text oxygenText;

	void Start()
	{
		SetOxygenText ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.Q)) 
		{
			DepleteOxygen ();
		}

		maxAir -= Time.deltaTime * 2.0f;
	}

	void DepleteOxygen()
	{
		if (maxAir > midAir) 
		{
			print ("Oxygen is fine");
		} 
		else if (maxAir > lowAir) 
		{
			print ("Mind your oxygen");
		} 
		else 
		{
			print ("Warning! Oxygen is critically low!");
		}

		SetOxygenText ();
	}

	void SetOxygenText ()
	{
		oxygenText.text = "Oxygen Meter: " + maxAir.ToString (); 
	}
}
