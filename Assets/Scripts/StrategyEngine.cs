using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StrategyEngine : MonoBehaviour, IPointerDownHandler, IPointerClickHandler,
    IPointerUpHandler, IPointerExitHandler, IPointerEnterHandler,
    IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject[] pitches;    
    GameObject swapObject1;
    GameObject swapObject2;
    string swapString1;
    string swapString2;
    Sprite swapSprite1;
    Sprite swapSprite2;

    void Update()
    {        
    }

    public void PitchStyleClick()
    {
        if (AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber].GetComponentInChildren<Text>().text == "2D ANIMATION")
        {
            pitches[0].SetActive(true);
        }
        else if (AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber].GetComponentInChildren<Text>().text == "TRAINING DRILL")
        {
            pitches[1].SetActive(true);
        }
        else if (AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber].GetComponentInChildren<Text>().text == "LINE-UP BAR A(BLACK)" || AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber - 1].GetComponentInChildren<Text>().text == "LINE-UP BAR A(BLUE)" || AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber - 1].GetComponentInChildren<Text>().text == "LINE-UP BAR A(YELLOW)" || AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber - 1].GetComponentInChildren<Text>().text == "LINE-UP BAR B(BLACK)" || AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber - 1].GetComponentInChildren<Text>().text == "LINE-UP BAR B(BLUE)" || AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber - 1].GetComponentInChildren<Text>().text == "LINE-UP BAR B(YELLOW)")
        {
            pitches[2].SetActive(true);
        }
    }

    public void FullScreenModeClick()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        if (eventData.pointerCurrentRaycast.gameObject.tag == "Sheet")
        {
            
            swapObject1 = eventData.pointerCurrentRaycast.gameObject;
            print(eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<GameObject>().name);
        }       
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.tag == "Sheet")
        {
            print(eventData.pointerCurrentRaycast.gameObject.name);
            swapObject2 = eventData.pointerCurrentRaycast.gameObject;
            swapString1 = swapObject1.GetComponentInParent<GameObject>().GetComponentInChildren<Text>().text;
            swapString2 = swapObject2.GetComponentInParent<GameObject>().GetComponentInChildren<Text>().text;
            swapSprite1 = swapObject1.GetComponent<Image>().sprite;
            swapSprite2 = swapObject2.GetComponent<Image>().sprite;
            swapObject1.GetComponentInParent<GameObject>().GetComponentInChildren<Text>().text = swapString2;
            swapObject2.GetComponentInParent<GameObject>().GetComponentInChildren<Text>().text = swapString1;
            swapObject1.GetComponent<Image>().sprite = swapSprite2;
            swapObject2.GetComponent<Image>().sprite = swapSprite1;

            if (swapObject1.GetComponentsInChildren<Image>()[0].enabled)
            {
                swapObject1.GetComponentInParent<GameObject>().GetComponentsInChildren<Image>()[0].enabled = false;
                swapObject2.GetComponentInParent<GameObject>().GetComponentsInChildren<Image>()[0].enabled = true;
            }
            else if (swapObject2.GetComponentsInChildren<Image>()[0].enabled)
            {
                swapObject1.GetComponentInParent<GameObject>().GetComponentsInChildren<Image>()[0].enabled = true;
                swapObject2.GetComponentInParent<GameObject>().GetComponentsInChildren<Image>()[0].enabled = false;
            }            
        }

        swapObject1 = null;
        swapObject2 = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //print(eventData.pointerCurrentRaycast.gameObject.name);
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
