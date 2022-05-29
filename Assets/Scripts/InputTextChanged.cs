using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTextChanged : MonoBehaviour
{
    public Text text;

    public void TextChanaged()
    {
        text.text = this.GetComponent<InputField>().text;
    }
}
