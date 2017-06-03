﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public AudioClip openingDoorSound;
    public AudioClip lockedDoorSound;
    public Animator openDoor;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    bool opening = false;

    bool isFullyOpened = false;

    void Update() {
        // If the door is opening and it is not fully raised
        if (opening && !isFullyOpened)
        {
            isFullyOpened = true;
            // Animate the door raising up
            openDoor.SetTrigger("OpenTheDoor");
            Collider collider = openDoor.GetComponent<Collider>();
            collider.enabled = false;
        }
    }

    public void OnDoorClicked() {
        AudioSource audioSource = GetComponent<AudioSource>();

        // If the door is clicked and unlocked
        if (!locked)
        {
            // Set the "opening" boolean to true
            opening = true;
            audioSource.clip = openingDoorSound;
        }
        else
        {
            // (optionally) Else
            // Play a sound to indicate the door is locked            
            audioSource.clip = lockedDoorSound;
        }

        audioSource.Play();
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
