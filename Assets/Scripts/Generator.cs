using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    private GameObject coinPrefab;

    [SerializeField]
    private GameObject bombPrefab;

    private const int count = 500;

    private void Start()
    {
        if (coinPrefab != null && bombPrefab != null)
        {
            for (int i = 0; i < count; i++)
            {
                var positionCoin = new Vector3(0, Random.Range(-70f, 60f), Random.Range(-534.6f, 530f));
                var positionBomb = new Vector3(0, Random.Range(-70f, 60f), Random.Range(-534.6f, 530f));

                Instantiate(coinPrefab, positionCoin, Quaternion.identity);
                Instantiate(bombPrefab, positionBomb, Quaternion.identity);
            }
        }
    }
}
