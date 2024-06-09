using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    [SerializeField]
    private Text labelCount;

    public void WriteCoins(int coins)
    {
        labelCount.text = coins.ToString();
    }
}
