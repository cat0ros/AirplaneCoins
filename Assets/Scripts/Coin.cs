using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private GameObject coinEffect;
    public void Collect()
    {
        Instantiate(coinEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
