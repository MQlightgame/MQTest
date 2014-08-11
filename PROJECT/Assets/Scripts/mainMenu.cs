using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	//GUI Code//
	/* Author: Rhys Clarke 
	 Created: 24/7/14 
	 Last Edited: 29/7/14
	 Last Edited by: Rhys Clarke */

	bool mmOpen = true; //Main menu open check
	
	void OnGUI() {
		var buttonWidth = 200; //width of buttons
		var buttonHeight = 50; //height of buttons

		if (mmOpen == true){
		
			//Background box
			//Increase background box height by buttonHeight (50) upon adding a new button
			GUI.Box(new Rect((Screen.width/2 - buttonWidth/2 - 25), Screen.height/2 - 125, 250, 200), "Main Menu");
			
			//Create layout onto background box to place button on.
			GUILayout.BeginArea(new Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - 100, buttonWidth, 400));
		
			//Play Button
			if (GUILayout.Button("Play", GUILayout.Height (50))){
				if (mmOpen == true){
					mmOpen = false; //closes main menu
					//Application.LoadLevel([put level here]);
				}
			}
			
			//Options button
			if (GUILayout.Button("Options", GUILayout.Height (50))){
			}
			
			//Exit button
			if (GUILayout.Button("Exit", GUILayout.Height (50))){
				Application.Quit();
			}
			GUILayout.EndArea();
		}
	}
}
