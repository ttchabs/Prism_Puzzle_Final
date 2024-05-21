using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternCardScript2 : MonoBehaviour
{

    public List<GameObject> PuzzleCards; // List of card game objects


    private GameObject Player2PuzzleCard;

    public Transform Player2PuzzlePosition;

    // Start is called before the first frame update
    void Start()
    {

    }


    

    public void Player2GetPuzzleCard ()
    {
        Player2PuzzleCard = PuzzleCards[Random.Range(0, PuzzleCards.Count)];
        Instantiate(Player2PuzzleCard, Player2PuzzlePosition.position, Quaternion.identity, Player2PuzzlePosition);

        Destroy(gameObject);




    }

}
