using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTextInPreset : MonoBehaviour
{
    public Text[] teamATexts;
    public Text[] teamBTexts;
    public Text[] competitionTexts;
    public Text[] roundTexts;
    public Text[] seasonTexts;
    public Text[] stadiumTexts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < teamATexts.Length; i++)
        {
            teamATexts[i].text = teamATexts[0].text;
        }

        for (int i = 0; i < teamBTexts.Length; i++)
        {
            teamBTexts[i].text = teamBTexts[0].text;
        }

        for (int i = 0; i < competitionTexts.Length; i++)
        {
            competitionTexts[i].text = competitionTexts[0].text;
        }

        for (int i = 0; i < roundTexts.Length; i++)
        {
            roundTexts[i].text = roundTexts[0].text;
        }

        for (int i = 0; i < seasonTexts.Length; i++)
        {
            seasonTexts[i].text = seasonTexts[0].text;
        }

        for (int i = 0; i < stadiumTexts.Length; i++)
        {
            stadiumTexts[i].text = stadiumTexts[0].text;
        }
    }
}
