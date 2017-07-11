using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basicCode : MonoBehaviour {
//	private InputField leisureTime;
//	private InputField distanceInMiles;
//	//Name input field
//	void Awake(){
//		leisureTime = GameObject.Find ("leisureInput").GetComponents<InputField> ();
//		distanceInMiles = GameObject.Find ("Distance").GetComponents<InputField> ();
//	}
		
	public InputField distanceInMilesInput;
	public float distanceInMiles;

	public InputField leisureTimeInput;
	public float leisureTime;


	public Text finalAmt;

	private float xportTime;
	private float avgSpeed;
	private float finalCost;
	private float costDenominator;
	private float totaltime;
	private float totalCost;

	public void onSubmit()
	{
		xportTime = 0.2f;
		avgSpeed = 0.2f;
		costDenominator = 10.2f;
		totaltime = 0.2f;
		totalCost = 0.2f;
		avgSpeed = 35.2f;

		//set lesure time = user input
		leisureTime = float.Parse(leisureTimeInput.text);

		//set distance in miles = user input
		distanceInMiles = float.Parse(distanceInMilesInput.text);

		//calculate xportime = distInMiles/augSpeed
		xportTime =	(distanceInMiles / avgSpeed)*60*2;

		//calculate totaltime = LeisTime + xportTime
		totaltime = (leisureTime + xportTime);

		//calculate totalCost = totaltime / costDenominator
		totalCost = (totaltime / costDenominator);

		//output totalCost to GUI textbox
		finalAmt.text = "$ " + Mathf.Round(totalCost).ToString();
		Debug.Log(totalCost);
	}
}