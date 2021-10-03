using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelContinue : MonoBehaviour
{
   [SerializeField] private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player finnished");
            other.gameObject.SetActive(false);
            //next level load

            //eventually we'll want to note time
            levelContinue();
        }
    }
  


    private void levelContinue()
    {
        //if all players are done, go to next level.
    }
}

