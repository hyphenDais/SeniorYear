using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CausticsAnimation : MonoBehaviour 
{
	public int tileColumn = 4;
	public int tileRow = 2;
	public int frames = 30;
	private int index;
	private Vector2 scale;

	// Update is called once per frame
	void Update () 
	{
		// Calculates how the animation will run
		index = (int)(Time.time * frames);

		// Repeat the calculation once all frames have been exhausted
		index = index % (tileColumn * tileRow);

		// Calculate how big each tile is
		scale = new Vector2(1.0f / tileColumn, 1.0f / tileRow);

		// Divide the columns and rows into seperate sections
		var uRow = index % tileRow;
		var uColumn = index / tileColumn;

		Vector2 offset = new Vector2 (uRow * scale.x, 1.0f - scale.y - uColumn * scale.y);

		GetComponent<Renderer>().material.SetTextureOffset ("_MainTex", offset);
		GetComponent<Renderer>().material.SetTextureScale ("_MainTex", scale);
	}
}
