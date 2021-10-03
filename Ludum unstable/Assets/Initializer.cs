using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        if (SavedData.PlayerLetters.Contains("s")){ S.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("b")){ B.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("c")){ C.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("r")){ R.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("h")){ H.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("z")){ Z.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("q")){ Q.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("i")){ I.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("l")){ L.SetActive(true); }
        if (SavedData.PlayerLetters.Contains("m")){ M.SetActive(true); }

    }
}
