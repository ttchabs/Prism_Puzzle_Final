using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAndHidButtons : MonoBehaviour
{

    public LayerMask Layer;
    private GameObject Lasthit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void HideCard()
    {

      

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 3, Layer);

        if (hit.collider != null)
        {
            GameObject Puzzle = hit.collider.gameObject;
            Lasthit = Puzzle;
            Puzzle.SetActive(false);
            
        }
        else
        {
            if (Lasthit != null)
            {
                Lasthit.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    public void ShowCard()
    {
       
    }

    
}
