using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.EditorUtilities {
    public class GameStarting : MonoBehaviour {
        // Start is called before the first frame update


        public int CurrentLevel;
       

        private bool started = false;

        public GameObject Overlay;

        public GameObject S;
        public GameObject B;
        public GameObject C;
        public GameObject R;
        public GameObject H;
        public GameObject Z;
        public GameObject Q;
        public GameObject I;
        public GameObject L;
        public GameObject M;

        private bool s = false;
        private bool b = false;
        private bool c = false;
        private bool r = false;
        private bool h = false;
        private bool z = false;
        private bool q = false;
        private bool i = false;
        private bool l = false;
        private bool m = false;

        private string finalList;

        void Start()
        {
            Time.timeScale = 0;
        }

        // Update is called once per frame
        void Update()
        {

            if ((started == false) && (Input.GetKeyDown(KeyCode.S)))
            {
                if (s == false)
                {
                    S.SetActive(true);
                    s = true;
                }
                else 
                { 
                    S.SetActive(false);
                    s = false;
                }
            }
            if ((started == false) && (Input.GetKeyDown(KeyCode.B)))
            {
                if (b == false)
                {
                    B.SetActive(true);
                    b = true;
                }
                else
                {
                    B.SetActive(false);
                    b = false;
                }
            }
            if ((started == false) && (Input.GetKeyDown(KeyCode.C)))
            {
                if (c == false)
                {
                    C.SetActive(true);
                    c = true;
                }
                else
                {
                    C.SetActive(false);
                    c = false;
                }
            }             
            if ((started == false) && (Input.GetKeyDown(KeyCode.R)))
            {
                if (r == false)
                {
                    R.SetActive(true);
                    r = true;
                }
                else
                {
                    R.SetActive(false);
                    r = false;
                }
            }
            if ((started == false) && (Input.GetKeyDown(KeyCode.H)))
            {
                if (h == false)
                {
                    H.SetActive(true);
                    h = true;
                }
                else
                {
                    H.SetActive(false);
                    h = false;
                }
            }
            if ((started == false) && (Input.GetKeyDown(KeyCode.Z)))
            {
                if (z == false)
                {
                    Z.SetActive(true);
                    z = true;
                }
                else
                {
                    Z.SetActive(false);
                    z = false;
                }
            }
            if ((started == false) && (Input.GetKeyDown(KeyCode.Q)))
            {
                if (q == false)
                {
                    Q.SetActive(true);
                    q = true;
                }
                else
                {
                    Q.SetActive(false);
                    q = false;
                }
            }
            if ((started == false) && (Input.GetKeyDown(KeyCode.I)))
            {
                if (i == false)
                {
                    I.SetActive(true);
                    i = true;
                }
                else
                {
                    I.SetActive(false);
                    i = false;
                }
            }
            if ((started == false) && (Input.GetKeyDown(KeyCode.L)))
            {
                if (l == false)
                {
                    L.SetActive(true);
                    l = true;
                }
                else
                {
                    L.SetActive(false);
                    l = false;
                }
            }
            if ((started == false) && (Input.GetKeyDown(KeyCode.M)))
            {
                if (m == false)
                {
                    M.SetActive(true);
                    m = true;
                }
                else
                {
                    M.SetActive(false);
                    m = false;
                }
            }


            if ((started == false)&&(Input.GetKeyDown(KeyCode.Space)))
            {
                if (s == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "s"; }
                if (b == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "b"; }
                if (c == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "c"; }
                if (r == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "r"; }
                if (h == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "h"; }
                if (z == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "z"; }
                if (q == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "q"; }
                if (i == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "i"; }
                if (l == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "l"; }
                if (m == true) { SavedData.PlayerLetters = SavedData.PlayerLetters + "m"; }


                Overlay.SetActive(false);
                ResumeGame();
                started = true;

            }
        }



        public void ResumeGame()
        {
            Time.timeScale = 1;
        }
    }
}
