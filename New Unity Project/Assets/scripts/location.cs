using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class location : MonoBehaviour {

	public SpinWheel needle;


	public int spinNumber;

	public List<float> angle = new List<float>();



	// Use this for initialization
	void Start () {
		spinNumber = 0;
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
		//CheckWho();
	}
	public float GetAngle(int index)
	{
		return angle[index];
	}

	private void CheckWho()
	{
		if(needle.CheckIfSpinning())
		{
			if(needle.GetCurrentAngle() > angle[0] && needle.GetCurrentAngle() < angle[1])
			{
				Debug.Log("Player 1");
			}
			else if(needle.GetCurrentAngle() > angle[1] && needle.GetCurrentAngle() < angle[2])
			{
				Debug.Log("Player 2");
			}
			else if(needle.GetCurrentAngle() > angle[2] && needle.GetCurrentAngle() < angle[3])
			{
				Debug.Log("Player 3");
			}
			else if(needle.GetCurrentAngle() > angle[3] && needle.GetCurrentAngle() < angle[4])
			{
				Debug.Log("Player 4");
			}
			else if(needle.GetCurrentAngle() > angle[4] && needle.GetCurrentAngle() < angle[5])
			{
				Debug.Log("Player 5");
			}
			else if(needle.GetCurrentAngle() > angle[5] && needle.GetCurrentAngle() < angle[6])
			{
				Debug.Log("Player 6");
			}
			else if(needle.GetCurrentAngle() > angle[6] && needle.GetCurrentAngle() < angle[7])
			{
				Debug.Log("Player 7");
			}
			else if(needle.GetCurrentAngle() > angle[7] && needle.GetCurrentAngle() < angle[8])
			{
				Debug.Log("Player 8");
			}
		}
	}


}
