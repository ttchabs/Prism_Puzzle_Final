using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAndWrongButtons : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startPosition;
    private Transform startParent;
    private bool isDragging = false;
    private Canvas canvas;

    private void Awake()
    {
        canvas = FindObjectOfType<Canvas>();
    }

    private void OnMouseDown()
    {
        // When the mouse button is pressed on the object
        startPosition = transform.position;
        startParent = transform.parent;
        isDragging = true;
        transform.SetParent(canvas.transform);  // Ensure the block is on top of other UI elements
    }

    private void OnMouseDrag()
    {
        // While the mouse button is held down
        if (isDragging)
        {
            Vector3 screenPoint = Input.mousePosition;
            screenPoint.z = Mathf.Abs(Camera.main.transform.position.z);  // Set this to the distance from the camera
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);
            transform.position = new Vector3(worldPoint.x, worldPoint.y, startPosition.z);
        }
    }

    private void OnMouseUp()
    {
        // When the mouse button is released
        isDragging = false;
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && hit.collider.CompareTag("R$WSlots"))
        {
            transform.position = hit.collider.transform.position;
            transform.SetParent(hit.collider.transform);  // Optional: Make the block a child of the slot
        }
        else
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }
}
