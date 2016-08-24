using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization - beginning of game
	void Start () {
		print ("Choose the range (maximum and minimum) that your chosen number is in");
		print ("What is the maximum number?");
		print ("What is the minimum number?");
		print ("Press Up Arrow to choose 1 - 1 000");
		print ("Press Left Arrow to choose 1 - 10 000");
		print ("Press Right Arrow to choose 1 - 30 000");
		
		max = LateUpdate();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	
	
		if (Input.GetKeyDown(KeyCode.Tab) ) 
		{
			// up arrow pressed
			min = guess;
			NextGuess ();
			
		} else if (Input.GetKeyDown (KeyCode.CapsLock) ) 
		{
			//  down arrow key pressed
			max = guess;
			NextGuess ();
			
		} else if (Input.GetKeyDown (KeyCode.Return) ) 
		{ // return is enter key
			print ("The computer won!");
			StartGame ();
		}
		
		
	}	
		
		
		
	int LateUpdate() {
		
		if (Input.GetKeyDown (KeyCode.UpArrow) )
		{
			max = 1000;
			print ("You picked  1 - 1 000, ");
			StartGame ();
			
		}
		
		else if (Input.GetKeyDown (KeyCode.LeftArrow) )
		{
			
			max = 10000;
			print ("You picked 1 - 10 000, ");
			StartGame ();
			
		}
		
		else if (Input.GetKeyDown (KeyCode.RightArrow) )
		{
			
			max = 30000;
			print ("You picked 1 - 30 000, ");
			StartGame ();
			
		}
		return max;
		
	}
	
	
	void StartGame() {
		
		min = 1;
		guess = (Random.Range(min, max)) ;
	
		max = max + 1 ;
		
		print ("-----------------------");
		print ("Welcome to NumberWizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + (max - 1) );
		print ("The lowest number you can pick is " + min);
		
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Tab = for higher, CapsLock = lower, and return = equal");
		
	}
	
	void NextGuess() {
		
		guess = (Random.Range(min, max)) ;
		print ("Higher or lower than " + guess);
		print ("Up = for higher, down = lower, and return = equal");
		
	}
}
