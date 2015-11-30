using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {

	private string name;

	private SpinWheel needle;

	public float LowAngle;
	public float HighAngle;

	private List<float> angle = new List<float>();

	public void SetRange(float low, float high)
	{
		LowAngle = low;
		HighAngle = high;
	}

	public void SetName(string setname)
	{
		name = setname;
	}
	public string GetName()
	{
		return name;
	}

	// Use this for initialization
	void Start () {
		needle = GameObject.FindGameObjectWithTag("needle").GetComponent<SpinWheel>();
		angle.Add(0);
		angle.Add(45);
		angle.Add(90);
		angle.Add(135);
		angle.Add(180);
		angle.Add(225);
		angle.Add(270);
		angle.Add(315);
		angle.Add(360);
	}



	// Update is called once per frame
	void Update () {
	}


}
