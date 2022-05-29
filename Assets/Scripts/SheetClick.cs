using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheetClick : MonoBehaviour
{
    public int sheetNumber;
    public int sheetMatchedNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {        
        AddSheet.Instance.selectedSheetNumber = sheetNumber;
        AddSheet.Instance.animationBars[0].SetActive(false);
        AddSheet.Instance.animationBars[1].SetActive(false);

        //print(AddSheet.Instance.MainSheets.Length);
        if (sheetNumber == AddSheet.Instance.sheetCount)
        {
            print(12312312);
            for (int i = 1; i < AddSheet.Instance.MainSheets.Length; i++)
            {
                AddSheet.Instance.MainSheets[i].SetActive(false);
            }

            AddSheet.Instance.sheetEditor.SetActive(true);
            AddSheet.Instance.mainMenu.SetActive(true);
        }
        else
        {
            print(12312312);
            for (int i = 1; i < AddSheet.Instance.MainSheets.Length; i++)
            {
                AddSheet.Instance.MainSheets[i].SetActive(false);
            }

            for (int i = 0; i < AddSheet.Instance.sheetsInScrollView.Length; i++)
            {
                AddSheet.Instance.sheetsInScrollView[i].GetComponentsInChildren<Image>()[0].enabled = false;
            }

            this.GetComponentsInChildren<Image>()[0].enabled = true;

            for (int i = 0; i < AddSheet.Instance.stringTitles.Count; i++)
            {
                if (this.GetComponentInChildren<Text>().text == AddSheet.Instance.stringTitles[i])
                {
                    AddSheet.Instance.MainSheets[i].SetActive(true);
                   
                    if (this.GetComponentInChildren<Text>().text == "2D ANIMATION")
                    {
                        AddSheet.Instance.animationBars[0].SetActive(true);
                    }
                    else if (this.GetComponentInChildren<Text>().text == "TRAINING DRILL")
                    {
                        AddSheet.Instance.animationBars[1].SetActive(true);
                    }
                }
            }
        }

        
    }
}
