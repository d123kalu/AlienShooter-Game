using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerExit2D(Collider2D other)
    {
        ScoreManager.instance.ChangeScore(coinValue);
    }


}
