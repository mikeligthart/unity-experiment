using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
	
		print ("============================");
		print ("Welcome to the number wizard");
		print ("Think of a number between " + min + "and " + max + " and don't tell me");
		print ("Is your number higher than, lower than or equal to " + guess + "?");
		print ("Press up for higher, down for lower and enter for equal");

		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = (min + max) / 2;
			print ("Is your number higher than, lower than or equal to " + guess + "?");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			guess = (min + max) / 2;
			print ("Is your number higher than, lower than or equal to " + guess + "?");
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
		}
	}
}
