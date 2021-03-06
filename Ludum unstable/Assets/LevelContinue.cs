using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelContinue : MonoBehaviour
{
    private static int currentlevel = 0;

    private static int totalFinalists = 0;

    private GameObject last;

    [SerializeField] private Rigidbody rig;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(other + " Player finnished");
            other.gameObject.SetActive(false);           
            totalFinalists++;
            //next level load

            //eventually we'll want to note time
            if (totalFinalists == SavedData.PlayerLetters.Length) //per player letter there is one player. so this checks the total number of players
            {
                Debug.Log(totalFinalists);
                levelContinue();
            }
        }
    }
  


    private void levelContinue()
    {
        totalFinalists = 0;
        currentlevel++;
        Debug.Log("LevelContinue triggered");
        //if all players are done, go to next level.
        SceneManager.LoadScene(currentlevel);

    }
}

