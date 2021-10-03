using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.EditorUtilities { 
public class Scoreboard : MonoBehaviour
{
        private bool gamedone = false;//set to true when the game is done ----- TODO

    [SerializeField] private TextMeshProUGUI timer;
    static float minutes = 0;
    static float seconds = 0;
    static float miliseconds = 0;


    void Update()
    {
        
        if ((miliseconds > 99)&&(gamedone==false))
        {
            if (seconds > 59)
            {
                minutes++;
                seconds = 00;
            }
            else if (seconds <= 59)
            {
                seconds++;
            }

            miliseconds = 0;
        }

        if(gamedone == false)
            {
                miliseconds += Time.deltaTime * 100;
            }
        

        //Debug.Log(string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds));

                timer.text = string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds);
      
        }

        public void endGame()
        {
            gamedone = true;
        }
}
}
