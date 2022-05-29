using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSheet : MonoBehaviour
{
    public static AddSheet Instance;
    public GameObject[] sheetsInScrollView;
    public Sprite[] sheetSprites;
    public Sprite[] backgroundSprites;
    public GameObject[] MainSheets;
    public GameObject sheetEditor;
    public GameObject mainMenu;
    public GameObject[] animationBars;

    public int sheetCount = 0;
    public List<string> stringTitles = new List<string>();
    public int selectedSheetNumber;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        stringTitles.Add("COVER TYPED(1)");
        stringTitles.Add("COVER TYPED(2)");
        stringTitles.Add("COVER TYPED(3)");
        stringTitles.Add("COVER TYPED(4)");
        stringTitles.Add("COVER TYPED(5)");
        stringTitles.Add("COVER TYPED(6)");
        stringTitles.Add("COVER TYPED(7)");
        stringTitles.Add("COVER TYPED(8)");
        stringTitles.Add("COVER TYPED(9)");
        stringTitles.Add("COVER TYPED(10)");
        stringTitles.Add("COVER TYPED(11)");
        stringTitles.Add("COVER TYPED(12)");
        stringTitles.Add("LINE-UP BAR A(BLACK)");
        stringTitles.Add("LINE-UP BAR A(BLUE)");
        stringTitles.Add("LINE-UP BAR A(YELLOW)");
        stringTitles.Add("LINE-UP BAR B(BLACK)");
        stringTitles.Add("LINE-UP BAR B(BLUE)");
        stringTitles.Add("LINE-UP BAR B(YELLOW)");
        stringTitles.Add("MAIN TITLE");
        stringTitles.Add("SUB TITLE");
        stringTitles.Add("BULLETPOINTS");
        stringTitles.Add("OPPOSITION PLAYER INFO");
        stringTitles.Add("2D ANIMATION");
        stringTitles.Add("BLANCO PAGE");
        stringTitles.Add("VIDEO (INCLUDING TEXT)");
        stringTitles.Add("VIDEO (NO TEXT)");
        stringTitles.Add("TRAINING DRILL");
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
}
