using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInRole : MonoBehaviour
{
    public GameObject[] playerRoleInterfaces;
    public Text playerRoleText;

    int count = 4000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackwardClick()
    {
        for (int i = 0; i < playerRoleInterfaces.Length; i++)
        {
            playerRoleInterfaces[i].SetActive(false);
        }

        switch (Int32.Parse(playerRoleText.text))
        {
            case 1:
                {
                    playerRoleText.text = "4";
                    playerRoleInterfaces[3].SetActive(true);
                    break;
                }
            case 2:
                {
                    playerRoleText.text = "1";
                    playerRoleInterfaces[0].SetActive(true);
                    break;
                }
            case 3:
                {
                    playerRoleText.text = "2";
                    playerRoleInterfaces[1].SetActive(true);
                    break;
                }
            case 4:
                {
                    playerRoleText.text = "3";
                    playerRoleInterfaces[2].SetActive(true);
                    break;
                }

        }        
    }

    public void ForwardClick()
    {
        print(Int32.Parse(playerRoleText.text));

        for (int i = 0; i < playerRoleInterfaces.Length; i++)
        {
            playerRoleInterfaces[i].SetActive(false);
        }
        
        switch (Int32.Parse( playerRoleText.text))
        {
            case 1:
                {
                    playerRoleText.text = "2";
                    playerRoleInterfaces[1].SetActive(true);
                    break;
                }
            case 2:
                {
                    playerRoleText.text = "3";
                    playerRoleInterfaces[2].SetActive(true);
                    break;
                }
            case 3:
                {
                    playerRoleText.text = "4";
                    playerRoleInterfaces[3].SetActive(true);
                    break;
                }
            case 4:
                {
                    playerRoleText.text = "1";
                    playerRoleInterfaces[0].SetActive(true);
                    break;
                }

        }
    }
}
