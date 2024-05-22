using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public Transform[] TargetSpots; // Assign the target spot in the Unity Editor
    public float snapDistance = 1f;
    private bool isDragging = false;
    private Vector3 offset;


    public GameObject player1screen;
    public GameObject player2screen;



    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.AddComponent<DragAndDrop>();


        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        offset = gameObject.transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {

        isDragging = false;

        foreach (Transform spots in transform.parent.GetComponent<DragAndDrop>().TargetSpots)
        {

            // Check if the object is close enough to the target spot to snap it into place
            float distance = Vector3.Distance(transform.position, spots.position);
            if (distance <= snapDistance)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(spots.position, snapDistance);

                foreach (Collider2D collider in colliders)
                {
                    if (collider.gameObject != gameObject)
                    {

                        // transform.position = OriginalPosition;
                        return;
                    }
                }
                transform.position = spots.position;
                break;
            }
            else
            {
                // transform.position = OriginalPosition;
            }

        }
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = GetMouseWorldPosition() + offset;
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }

    }



    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}

