using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardScript : MonoBehaviour
{
    public GameObject commcard; // The button you want to move
    public Transform newParent; // The new panel you want to move the button to

    public void MoveButtonToNewPanel()
    {
        if (commcard != null && newParent != null)
        {
            commcard.transform.SetParent(newParent);
        }
        else
        {
            Debug.LogWarning("Button or new parent is not assigned.");
        }
    }

    
}
