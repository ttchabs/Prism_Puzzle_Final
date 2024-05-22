using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    private GameObject PlayerSwapPanel;
    private Vector3 StartPosition = new Vector3(11.27f, 0, 90);
    private Vector3 NextPosition = new Vector3(-11.27f, 0, 90);

    private GameObject Player1PuzzleBoard;
    private GameObject Player2PuzzleBoard;

    private Vector3 SmallBoardSize = new Vector3(0.5f , 0.5f, 0);

    public Vector3 SmallBlockPosition = new Vector3(-0.186f, 3.492f, 90);
    public Vector3 OriginalPosition = new Vector3(2.768f, -1.786f, 90);


    public Vector3 SmallBlock2Position = new Vector3(-0.186f, 3.492f, 90);
    public Vector3 Original2Position = new Vector3(2.768f, -1.786f, 90);

    private Vector3 OriginalSize = new Vector3(1,1,0);

    public GameObject Player1Blocks;
    public GameObject Player2Blocks;



    public void Start()
    {
        PlayerSwapPanel = GameObject.FindGameObjectWithTag("DragPanel");
        

        Player1PuzzleBoard = GameObject.FindGameObjectWithTag("Player1Board");
        Player2PuzzleBoard = GameObject.FindGameObjectWithTag("Player2Board");

    }


    public void SwitchTOPLayer1()
    {
        PlayerSwapPanel.transform.position = StartPosition;
        Player2PuzzleBoard.transform.localScale = SmallBoardSize;
        Player2PuzzleBoard.transform.position = SmallBlock2Position;

        Player1PuzzleBoard.transform.position = OriginalPosition;
        Player1PuzzleBoard.transform.localScale = OriginalSize;

        Player1Blocks.SetActive(true);
        Player2Blocks.SetActive(false);



    }

    public void SwitchTOPLayer2()
    {
        PlayerSwapPanel.transform.position = NextPosition;
        Player1PuzzleBoard.transform.localScale = SmallBoardSize;
        Player1PuzzleBoard.transform.position = SmallBlockPosition;

        Player2PuzzleBoard.transform.localScale = OriginalSize;
        Player2PuzzleBoard.transform.position = Original2Position;

        Player2Blocks.SetActive(true);
        Player1Blocks.SetActive(false);

    }
}
