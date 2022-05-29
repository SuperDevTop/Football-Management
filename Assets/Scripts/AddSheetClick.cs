using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSheetClick : MonoBehaviour
{
    public int sheetNumber;
    public string stringTitle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SheetClick()
    {
        AddSheet.Instance.sheetCount++;
        AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.sheetCount].SetActive(true);

        for (int i = 0; i < AddSheet.Instance.sheetsInScrollView.Length; i++)
        {
            AddSheet.Instance.sheetsInScrollView[i].GetComponentsInChildren<Image>()[0].enabled = false;
        }

        AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.sheetCount - 1].GetComponentsInChildren<Image>()[0].enabled = true;
        AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.sheetCount - 1].GetComponentsInChildren<Image>()[1].sprite = AddSheet.Instance.sheetSprites[sheetNumber];
        AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.sheetCount - 1].GetComponentInChildren<Text>().text = AddSheet.Instance.stringTitles[sheetNumber];
        AddSheet.Instance.selectedSheetNumber = AddSheet.Instance.sheetCount - 1;        

        if (sheetNumber >= 0 && sheetNumber <= 11)
        {
            AddSheet.Instance.MainSheets[0].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
            AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.sheetCount - 1].GetComponentsInChildren<Image>()[1].sprite = this.GetComponent<Image>().sprite;
            //print((Texture2D)this.GetComponent<Image>().sprite.texture);
        }        
    }
}
