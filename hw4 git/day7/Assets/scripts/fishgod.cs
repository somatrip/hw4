using UnityEngine;
using System.Collections;
using System.Collections.Generic; //You need this line to use lists.

public class fishgod : MonoBehaviour {
	
	public fish fishBlueprint;
	public fish fishBlueprint2;
	public int fishCount = 100;
	
	public List<fish> fishList = new List<fish>();

	// Use this for initialization
	void Start () {
		int currentFishCounter = 0;
		while ( currentFishCounter < fishCount ) {
			var randomNumber = 10 * ( Random.value );
				
		if (randomNumber < 5) {
				
			//spawn a fish	
			 Vector3 fishPosition = Random.insideUnitSphere * 100f;
			fish newfish = Instantiate( fishBlueprint, fishPosition, Quaternion.identity) as fish;
			fishList.Add (newfish);
			
			//increment our fish counter
			currentFishCounter++;
				
			}		
		else
			{
			//spawn a fish
        	 Vector3 fishPosition = Random.insideUnitSphere * 100f;
			fish newfish = Instantiate( fishBlueprint2, fishPosition, Quaternion.identity) as fish;
			fishList.Add (newfish);
			
			//increment our fish counter
			currentFishCounter++;
		
			}
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
		if ( Input.GetKeyDown( KeyCode.Space ) ) {
			
			foreach (fish currentfish in fishList ) {
				currentfish.destination = Vector3.zero;
				
			}
			
		}
	
	}
}
