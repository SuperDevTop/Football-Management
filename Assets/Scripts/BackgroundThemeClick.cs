using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundThemeClick : MonoBehaviour
{
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
        for (int i = 0; i < AddSheet.Instance.stringTitles.Count; i++)
        {
            if (AddSheet.Instance.sheetsInScrollView[AddSheet.Instance.selectedSheetNumber].GetComponentInChildren<Text>().text == AddSheet.Instance.stringTitles[i])
            {
                AddSheet.Instance.MainSheets[i].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
            }
        }
       
    }
}
