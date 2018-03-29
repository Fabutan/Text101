using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheChase : MonoBehaviour {

	public Text content;

	private enum States {
		state1Escape,
		state2Steak,
		state3Leash,
		state4Outside0,
		state5Outside1,
		state6Chase0,
		state6Chase1,
		state7UseSteak,
		state8Approach,
		state9Whistle,
		state10GoBack,
		state11WasteSteak,
		state12Pounce,
		state13OpenGate,
		state14Herd,
		state15Command,
		state16SteakYard,
		state17GoodGirl,
		state18BadGirl
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.state1Escape;
	}



	// Update is called once per frame
	void Update () {
		if (myState == States.state1Escape) 				{Escape ();}
		else if (myState == States.state2Steak) 			{Steak ();}
		else if (myState == States.state3Leash) 			{Leash ();}
		else if (myState == States.state4Outside0) 			{Outside0 ();}
		else if (myState == States.state5Outside1) 			{Outside1 ();}
		else if (myState == States.state6Chase0) 			{Chase0 ();}
		else if (myState == States.state6Chase1) 			{Chase1 ();}
		else if (myState == States.state7UseSteak) 			{UseSteak ();}
		else if (myState == States.state8Approach) 			{Approach ();}
		else if (myState == States.state9Whistle) 			{Whistle ();}
		else if (myState == States.state10GoBack)	 		{GoBack ();}
		else if (myState == States.state11WasteSteak) 		{WasteSteak ();}
		else if (myState == States.state12Pounce) 			{Pounce ();}
		else if (myState == States.state13OpenGate) 		{OpenGate ();}
		else if (myState == States.state14Herd)	 			{Herd ();}
		else if (myState == States.state15Command) 			{Command ();}
		else if (myState == States.state16SteakYard) 		{SteakYard ();}
		else if (myState == States.state17GoodGirl) 		{GoodGirl ();}
		else if (myState == States.state18BadGirl) 			{BadGirl ();}
	}

	#region State Handler Methods
	void Escape(){
		content.text = "Shit! The door was only open a crack, and just like that, Beppu was on the loose!\n\n" +
		"Press 1 to Go After Her!\n\n" +
		"Press 2 to Grab A Leash \n\n" +
		"Press 3 to Grab A Snack";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state4Outside0;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.state3Leash;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			myState = States.state2Steak;
		}
	}

	void Steak(){
		content.text = "You grabbed a nice bloody raw steak from the fridge, but now what!?\n\n" +
			"Press 1 to Go After Her!\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state5Outside1;
		}
	}

	void Leash(){
		content.text = "Where the hell is her leash! It's nowhere to be found, you don't have " +
			"time for this she's getting away!\n\n" +
			"Press 1 to Go After Her!\n\n" +
			"Press 2 to Grab A Snack";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state4Outside0;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.state2Steak;
		} 
	}

	void Outside0(){
		content.text = "She's bolting back an forth between traffic! But you can't get her attention!" +
			"Maybe a distraction would work?\n\n" +
			"Press 1 to Give Chase!\n\n" +
			"Press 2 to Go Back";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state6Chase0;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.state1Escape;
		} 
	}

	void Chase0(){
		content.text = "She's like a rabbit, you would never be able to catch her like this!\n\n" +
		"Press 1 to Continue\n\n";

			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				myState = States.state4Outside0;
			}
		}

	void Outside1(){
		content.text = "She's Bolting back and forth between traffic but you can't get her attention!" +
		"Maybe a distraction would work?\n\n" +
		"Press 1 to Give Chase!\n\n" +
		"Press 2 to Use Steak\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state6Chase1;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.state7UseSteak;
		} 
	}

	void Chase1(){
		content.text = "She's like a rabbit, you would never be able to catch her like this!\n\n" +
			"Press 1 to Continue\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state5Outside1;
		}
	}

	void UseSteak(){
		content.text = "The Raw Meat catches her eye, she immediately stops and stares you down.\n\n" +
			"Press 1 to Approach Slowly!\n\n" +
			"Press 2 to Whistle To Her\n\n" +
			"Press 3 to Go Back";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state8Approach;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.state9Whistle;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			myState = States.state10GoBack;
		}
	}

	void Approach(){
		content.text = "It's clear that she's not going to fall for that, and she's off like a bullet!.\n\n" +
		"Press 1 to Try Something Else\n\n";

			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				myState = States.state5Outside1;
			}
	}

	void Whistle(){
		content.text = "Phweet*! Nothing, she's too interested in the neighbor's compost bin to notice you.\n\n" +
		"Press 1 to Try Something Else\n\n";

			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				myState = States.state5Outside1;
			}
	}


	void GoBack(){
		content.text = "It's working, she's cautiously following you back towards the yard.\n\n" +
			"Press 1 to Open The Gate\n\n" +
			"Press 2 to Toss Some Steak\n\n" +
			"Press 3 to Pounce on Her!\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state13OpenGate;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.state11WasteSteak;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			myState = States.state12Pounce;
		}
	}


	void WasteSteak(){
		content.text = "She snaps it out of the air with glee! More Please!\n\n" +
			"Press 1 to Try Something Else\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state10GoBack;
		}
	}

	void Pounce(){
		content.text = "Not only does she squirm out of your grip, but you've lost the tenuous trust " +
			"that you worked so hard to establish.\n\n" +
			"Press 1 to Try Something Else\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state5Outside1;
		}
	}

	void OpenGate(){
		content.text = "The gate is now open, but she's still not totally convinced.\n\n" +
			"Press 1 to Herd Her Into The Yard\n\n" +
			"Press 2 to Command Her To Come\n\n" +
			"Press 3 to Use Steak";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state14Herd;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.state15Command;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			myState = States.state16SteakYard;
		}
	}


	void Herd(){
		content.text = "You circle around her slowly but she's more agile than you!" +
			"She immediately bolts.\n\n" +
			"Press 1 to Try Something Else\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state5Outside1;
		}
	}

	void Command(){
		content.text = "BEPPU COME HERE!!!\n\n\n\n Even your mightiest commands fall on deaf little ears.\n\n" +
			"Press 1 to Try Something Else\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state13OpenGate;
		}
	}

	void SteakYard(){
		content.text = "You toss a delectible morsel into the back yard.\n" +
			"She fell for it! Slamming the gate behind her, your fuzzy little prisoner " + 
			"is once again where she belongs. \n\n" +
			"Press 1 to Good Girl \n\n" +
			"Press 2 to BAD GIRL! \n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.state17GoodGirl;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.state18BadGirl;
		}
	}

	void GoodGirl(){
		content.text = "She stares blankly into the distance, it would seem your praise went unnoticed.\n" +
			"You win, I guess... The End\n\n" +
			"Press Spacebar To Play Again\n\n";

		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.state1Escape;
		} 
	}

	void BadGirl(){
		content.text = "She stares blankly into the distance, it would seem your punishment went unnoticed.\n" +
			"You win, I guess... The End\n\n" +
			"Press Spacebar To Play Again\n\n";

		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.state1Escape;
		} 
	}
	#endregion
}