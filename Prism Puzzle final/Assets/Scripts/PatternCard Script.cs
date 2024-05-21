using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternCardScript : MonoBehaviour
{

    public List<GameObject> PuzzleCards; // List of card game objects


    private GameObject Player1PuzzleCard;

    public Transform Player1PuzzlePosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Player1GetPuzzleCard ()
    {
        Player1PuzzleCard = PuzzleCards[Random.Range(0, PuzzleCards.Count)];
        Instantiate(Player1PuzzleCard, Player1PuzzlePosition.position, Quaternion.identity, Player1PuzzlePosition );

        Destroy(gameObject);


    }

   

}
