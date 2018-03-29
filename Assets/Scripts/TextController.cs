using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text content;

	private enum States {entranceway0, entranceway1, lightswitch, lookaround, coat, leave, listen,smokeDetectorReset, investigateBeeping,endGame, investigateScratching, scratchingSuccess, scratchingFailure};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.entranceway0;
	}



	// Update is called once per frame
	void Update () {
		if (myState == States.entranceway0) 				{state_entranceway0 ();}
		else if (myState == States.lightswitch) 			{state_lightswitch ();}
		else if (myState == States.lookaround) 				{state_lookaround ();}
		else if (myState == States.coat) 					{state_coat ();}
		else if (myState == States.leave) 					{state_leave ();}
		else if (myState == States.listen) 					{state_listen ();}
		else if (myState == States.investigateBeeping) 		{state_investigateBeeping ();}
		else if (myState == States.investigateScratching) 	{state_investigateScratching ();}
		else if (myState == States.scratchingFailure) 		{state_scratchingFailure ();}
		else if (myState == States.scratchingSuccess) 		{state_scratchingSuccess ();}
		else if (myState == States.smokeDetectorReset) 		{state_smokeDetectorReset ();}
		else if (myState == States.endGame) 				{state_endGame ();}
			
	}


	void state_entranceway0(){
		content.text = "Boots dripping from the rain, I hang my coat on the nearest hook " +
		"adorning the entranceway. I know this place like the back of my hand, it's colorful " +
		"turquoise lapping at the edges of a tan stained wooden floor.\n\n" +
		"Press 1 to Turn On Lights \n\n" +
		"Press 2 to Grab Your Coat \n\n" +
		"Press 3 to Listen To Surroundings";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.lightswitch;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.coat;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			myState = States.listen;
		}
	}

	void state_entranceway1(){
		content.text = "You stand blinking in an old Saint Boniface house. Though the task ahead /n/n" +
			"weighs heavily on you, you steel yourself for action. \n\n" +
			"Press 1 to Turn Look Around \n\n" +
			"Press 2 to Grab Your Coat \n\n" +
			"Press 3 to Listen To Surroundings";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.lookaround;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.coat;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			myState = States.listen;
		}
	}

	void state_lookaround(){
		content.text = "The evidence is all around you, hair everywhere, that musky smell." + 
			"If only you could close your eyes and convince yourself you were somewhere else.\n\n" +
			"Press 2 to Grab Your Coat \n\n" +
			"Press 3 to Listen To Surroundings";
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.coat;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			myState = States.listen;
		}
	}



	void state_lightswitch(){
		content.text = "You grope the wall opposite your coat for a few brief moments before your " +
		"thumb finds the familiar little click of the switch. \n\n " +
		"Your eyes burn slightly as they adjust to your newly illuminated surroundings.\n\n" +
		"Press 1 to Look Around \n\n" +
		"Press 2 to Grab Your Coat \n\n" +
		"Press 3 to Listen To Surroundings \n\n";
		
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.lookaround;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.coat;
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			myState = States.listen;	
		}
	}

	void state_coat(){
		content.text = "You question why you even entered this old house. You Grab your coat, ready to leave. As uninviting as the weather " +
		"may be, it's still easier to think about than what lies ahead in wait. \n\n" +
		"Press 1 to Go Outside \n\n" +
		"Press 2 to Return Coat \n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.leave;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.entranceway0;
		}
	}
	void state_leave(){
		content.text = "You pause for a brief moment unsure of of your decision, but It's too much to bear. " +
				"You shake the excess water from your coat, throw it over your shoulders and vanish into " +
				"the rainy night. \n\n" +
				"The End\n\n" +
				"Press Spacebar to Admit Defeat.";

			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.endGame;
		} 
	}

	void state_listen (){
		content.text = "A faint beeping can be heard coming from somewhere above you.\n\n" +
			"Something small is scratching at wood nearby.\n\n" +
			"Press 1 to Investigate The Beeping \n\n" +
			"Press 2 to Investigate the Scratching\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.investigateBeeping;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.investigateScratching;
		}
	
	}

	void state_investigateBeeping (){
		content.text = "You slowly walk through the house, ears trained on the faint intermittent beeps " +
			"that seem to be coming form the second floor.\n\n" +
			"It's a smoke detector, the battery must be dead. Resetting the device ceases the beeping.\n\n" +
			"Now the scratching has stopped.\n\n" +
			"Press 1 to Investigate the Scratching\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.smokeDetectorReset;
		}


	}

	void state_investigateScratching (){
		content.text = "As you approach a closed door on the second foor, you notice the scratching getting more and more frantic.\n\n" +
			"You reach for the handle, before pausing to think.\n\n" +
			"Press 1 to Open The Door\n\n" +
			"Press 2 to Listen Closely\n\n";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.scratchingFailure;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.listen;
		}

	}


	void state_scratchingFailure (){
		content.text = "Turning the doorknob you feel a sudden burst as the door flies open.\n\n" +
			"OH GOD, OH NO! A brown furball skitters past you, leaving nasty streaks of poop everywhere she goes, what a mess!\n\n" +
			"This is the worst thing ever.\n\n" +
			"Press 1 to Clean It Up";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.endGame;
		} 

	}

	void state_smokeDetectorReset (){
		content.text = "With the beeping stopped, you hear the scratching slow to a halt, then silence.\n\n" +
			"You follow the scratching to a bedroom door, and slowly reach for the doorknob.\n\n" +
			"Press 1 To Open Door";

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.scratchingSuccess;
		} 

	}

	void state_scratchingSuccess (){
		content.text = "Turning the doorknob you see a little dog sitting patiently for you. Beppu has waited patiently for a walk.\n\n" +
		"Press Spacebar To Take Her For a Walk\n\n";

		if (Input.GetKeyDown (KeyCode.Space)) {
			myState = States.endGame;
		} 

	}

	void state_endGame (){
		content.text = "The End\n\n" +
			"Press Space To Retry";

		if (Input.GetKeyDown (KeyCode.Space)) {
			state_entranceway0 ();
		}
	}
}