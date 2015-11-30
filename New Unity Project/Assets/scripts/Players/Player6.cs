using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player6 : MonoBehaviour {
	Player player = new Player();
	public SpinWheel needle;
	
	public location loc;
	// Use this for initialization
	void Start () {
		player.SetName("Jasmin");

	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = player.GetName();
		CheckMe(5,6);
	}

	public void CheckMe(int lowIndex, int highIndex)
	{
		player.SetRange(loc.angle[lowIndex],loc.angle[highIndex]);
		if(needle.CheckIfSpinning())
		{
			if(needle.GetCurrentAngle() > player.LowAngle && needle.GetCurrentAngle() < player.HighAngle)
			{
				Debug.Log(player.GetName());
			}
		}
	}
}
