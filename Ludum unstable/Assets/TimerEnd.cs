using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.EditorUtilities {
    public class TimerEnd : MonoBehaviour {
        [SerializeField] private Scoreboard score;
        // Start is called before the first frame update
        void Update()
        {
            score.endGame();
        }


    }
}
