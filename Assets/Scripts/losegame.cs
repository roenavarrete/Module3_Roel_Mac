using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losegame : MonoBehaviour
{




    public GameObject alien;
    public GameObject EndGameMenu;
    // Start is called before the first frame update
    void Start()
    {
        EndGameMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("aliendetector"))
        {

           
            EndGameMenu.SetActive(true);
            alien.SetActive(false);


        }

    }



}
