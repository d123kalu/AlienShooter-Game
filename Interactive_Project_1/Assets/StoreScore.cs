using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StoreScore : MonoBehaviour
{
    public Text textname;
    public TextMeshProUGUI textscore;

    // Start is called before the first frame update


    public void Writefile()
    { 
        string text = textname.text + " = " + textscore.text + "\n";
        Debug.Log(textname.text);
        System.IO.File.AppendAllText(Application.dataPath + "/Highscore.txt", text);
    }
}
