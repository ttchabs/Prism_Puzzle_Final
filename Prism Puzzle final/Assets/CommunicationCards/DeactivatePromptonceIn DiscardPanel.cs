using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeactivatePromptonceInDiscardPanel : MonoBehaviour
{
    public GameObject CommDiscard;

    void Update()
    {
        if (transform.parent == CommDiscard.transform)
        {
            DeactivateButton();
        }
    }

    void DeactivateButton()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.interactable = false; 
        }
        else
        {
            Debug.LogWarning("No Button component found on this GameObject.");
        }
    }
}
