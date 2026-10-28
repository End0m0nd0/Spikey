using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    Text CoinsText;

    void Update()
    {
        CoinsText = gameObject.GetComponent<Text>();
        CoinsText.text = "Coins: " + Game_Manager.coin.ToString();
    }
}
