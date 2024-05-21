using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimerScript : MonoBehaviour
{

    public TextMeshProUGUI Timertext;
    public TextMeshProUGUI Timertext2;

    private int minutes = 25;
    private int seconds = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer()
    {
        int totalTime = (minutes * 60) + seconds;

        while (totalTime > 0)
        {
            int displayMinutes = totalTime / 60;
            int displaySeconds = totalTime % 60;

            Timertext.text = string.Format("{0:D2} : {1:D2}", displayMinutes, displaySeconds);
            Timertext2.text = string.Format("{0:D2} : {1:D2}", displayMinutes, displaySeconds);

            yield return new WaitForSeconds(1);

            totalTime--;
        }

        Timertext.text = "00 : 00";
        Timertext2.text = "00 : 00";
    }



}

