using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternCardScript2 : MonoBehaviour
{

    public List<GameObject> PuzzleCards; // List of card game objects


    private GameObject Player2PuzzleCard;

    public Transform Player2PuzzlePosition;

    private GameObject GetPuzzleButton1;
    private GameObject GetPuzzleButton2;

    // Start is called before the first frame update
    void Start()
    {
        GetPuzzleButton1 = GameObject.FindGameObjectWithTag("P1GPB");
        GetPuzzleButton2 = GameObject.FindGameObjectWithTag("P2GPB");

    }




    public void Player2GetPuzzleCard ()
    {
        Player2PuzzleCard = PuzzleCards[Random.Range(0, PuzzleCards.Count)];
        Instantiate(Player2PuzzleCard, Player2PuzzlePosition.position, Quaternion.identity, Player2PuzzlePosition);

        Destroy(gameObject);




    }

}
