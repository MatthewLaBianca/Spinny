using UnityEngine;
using System.Collections;

public class SpinWheel : MonoBehaviour {

	public AnimationCurve animationCurve;
	public float amountOfRotations;
	private bool spinning;

	public bool isClockwise;


	private float currentAngle;

	// Use this for initialization
	void Start () {
		spinning = false;
	}

	// Update is called once per frame
	void Update () {
		float location = Random.Range(0.0f,359.0f);
		if(!spinning&& Input.GetKey(KeyCode.Space))
		{
			StartCoroutine(DoSpin(10.0f,location));
			currentAngle = location;
			Debug.Log(currentAngle);
		}
	}



	IEnumerator DoSpin(float time,float angle)
	{
		transform.rotation = new Quaternion(0,0,0,0);
		spinning = true;
		float timer = 0;
		if(isClockwise)
		{
			angle -= 360*amountOfRotations;
		}else
		{
			angle += 360*amountOfRotations;
		}
		float startAngle = transform.eulerAngles.z;

		while (timer < time)
		{
			float endAngle = animationCurve.Evaluate(timer/time)*angle;
			transform.eulerAngles = new Vector3(0.0f,0.0f,(endAngle+startAngle));
			timer += Time.deltaTime;
			yield return 0;
		}
		spinning = false;
	}

	public bool CheckIfSpinning()
	{
		return spinning;
	}

	public float GetCurrentAngle()
	{
		return currentAngle;
	}

}
