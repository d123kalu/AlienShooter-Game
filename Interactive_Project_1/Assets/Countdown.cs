using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float timeLeft = 300.0f;
    public Text startText; 
    public TextMeshProUGUI finalscore;
    public GameObject FinalMessagePanel;

    public Text test;

    public GameObject player;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = "Time Left: " + (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            startText.text = "Time Left: 0";
            FinalMessagePanel.gameObject.SetActive(true);
            test.text = "Score is: " + finalscore.text;

            int currentscore;

            int.TryParse(finalscore.text, out currentscore);

            Destroy(player);

        }
    }


}
