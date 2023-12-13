using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public int coins = 0;
    public TextMeshProUGUI coinCountText;

    // Start is called before the first frame update
    void Start()
    {
        coinCountText.text = "Coins: 0";
    }

    public void UpdateCoinCount()
    {
        coins++;
        coinCountText.text = "Coins: " + coins.ToString();
    }
}
