using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringPanelToTheFront : MonoBehaviour
{
    private Vector3 originalPosition;
    public float frontZPosition = -1f; // Set this to a value that brings the object in front

    void Awake()
    {
        originalPosition = transform.position;
    }

    void OnEnable()
    {
        transform.position = new Vector3(originalPosition.x, originalPosition.y, frontZPosition);
    }

    void OnDisable()
    {
        transform.position = originalPosition;
    }
}
