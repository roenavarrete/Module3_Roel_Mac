using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject door;
    public float contactDistance;
    public TMP_Text winConditionText;
    public GameObject alien;
    public GameObject exitPosition;
    public GameObject endGameSpot;
    public List<GameObject> disableList;
    public float doorOpenY = 1.2f;
    public float openSpeed = 2.0f;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(alien.transform.position, transform.position) < contactDistance)
        {
            endGame();
            winConditionText.text = "You Lose!";
        } else if (Vector3.Distance(exitPosition.transform.position, transform.position) < contactDistance && !gameOver)
        {
            endGame();
        }
    }

    void endGame()
    {
        float step = openSpeed * Time.deltaTime;
        door.transform.position = new Vector3(door.transform.position.x, doorOpenY, door.transform.position.z);
        alien.SetActive(false);
        transform.position = endGameSpot.transform.position;
        for (int i = 0; i < disableList.Count; i++)
        {
            disableList[i].SetActive(false);
        }
        gameOver = true;
    }
}
