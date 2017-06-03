using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public AudioClip openingChestSound;
    public Animator openChest;
    bool isChestClicked = false;
    bool isAlreadyOpened = false;

    private void Update()
    {
        if (isChestClicked && !isAlreadyOpened)
        {
            isAlreadyOpened = true;
            AudioSource audioSource = GetComponent<AudioSource>();
            openChest.SetBool("OpenChest", true);
            audioSource.clip = openingChestSound;
            audioSource.Play();
        }

        if (isAlreadyOpened && !openChest.GetCurrentAnimatorStateInfo(0).IsName("Chest Top Animation"))
        {

        }
    }

    public void OnChestClicked()
    {
        isChestClicked = true;
    }
}
