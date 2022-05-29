using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class AnimationController : MonoBehaviour, IPointerDownHandler, IPointerClickHandler,
    IPointerUpHandler, IPointerExitHandler, IPointerEnterHandler,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject[] players;
    public GameObject ball;
    public GameObject[] frameButtons;
    List<Vector3>[] playerPositions;
    List<Vector3> ballPosition;

    bool isDrag;
    bool isAnimationPlay;
    GameObject dragObject;
    int frameCount;
    int currentFrame;
    int count;

    void Update()
    {
        if (isDrag)
        {
            dragObject.transform.position = Input.mousePosition;
        }

        if (isAnimationPlay)
        {
            if (currentFrame < frameCount)
            {
                if (count == 100)
                {
                    count = 0;
                    currentFrame++;
                }
                else
                {
                    count++;
                    ball.transform.position = new Vector3(ballPosition[currentFrame].x + (ballPosition[currentFrame + 1].x - ballPosition[currentFrame].x) * count / 100, ballPosition[currentFrame].y + (ballPosition[currentFrame + 1].y - ballPosition[currentFrame].y) * count / 100, ballPosition[currentFrame].z + (ballPosition[currentFrame + 1].z - ballPosition[currentFrame].z) * count / 100);

                    for (int i = 0; i < playerPositions.Length; i++)
                    {
                        players[i].transform.position = new Vector3(playerPositions[i][currentFrame].x + (playerPositions[i][currentFrame + 1].x - playerPositions[i][currentFrame].x) * count / 100, playerPositions[i][currentFrame].y + (playerPositions[i][currentFrame + 1].y - playerPositions[i][currentFrame].y) * count / 100, playerPositions[i][currentFrame].z + (playerPositions[i][currentFrame + 1].z - playerPositions[i][currentFrame].z) * count / 100);
                    }
                }
            }
        } 
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {   
       

    }

    public void OnPointerClick(PointerEventData eventData)
    {        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (eventData.pointerCurrentRaycast.gameObject == players[i])
            {
                dragObject = players[i];
                isDrag = true;
            }
            else if (eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Image>().gameObject == players[i])
            {
                dragObject = players[i];
                isDrag = true;
            }
        }


        if (ball == eventData.pointerCurrentRaycast.gameObject)
        {
            dragObject = ball;
            isDrag = true;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDrag = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        

        playerPositions = new List<Vector3>[22];

        for (int i = 0; i < playerPositions.Length; i++)
        {
            playerPositions[i] = new List<Vector3>();
        }

        ballPosition = new List<Vector3>();

        for (int i = 0; i < players.Length; i++)
        {
            playerPositions[i].Add(players[i].transform.position);
        }

        ballPosition.Add(ball.transform.position);
    }

    public void AddFrame()
    {
        frameCount++;

        for (int i = 0; i < frameButtons.Length; i++)
        {
            frameButtons[i].SetActive(false);
        }

        for (int i = 0; i <= frameCount; i++)
        {
            frameButtons[i].SetActive(true);
        }

        for (int i = 0; i < players.Length; i++)
        {
            playerPositions[i].Add(players[i].transform.position);
        }

        ballPosition.Add(ball.transform.position);
    }

    public void PlayAnimation()
    {
        currentFrame = 0;

        for (int i = 0; i < players.Length; i++)
        {
            players[i].transform.position = playerPositions[i][0];
        }

        ball.transform.position = ballPosition[0];

        if (ballPosition.Count > 1)
        {            
            isAnimationPlay = true;            
        }       
    }

}
