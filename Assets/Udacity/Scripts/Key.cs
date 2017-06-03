using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public bool keyCollected = false;
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public GameObject door;
	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        Instantiate(keyPoof, transform.position, Quaternion.Euler(270, 0, 0));
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        door.SendMessage("Unlock");
        // Set the Key Collected Variable to true
        keyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
