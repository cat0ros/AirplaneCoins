using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plain : MonoBehaviour
{
    public int CountCoins { get; private set; }
    public int Health { get; private set; } = 100;

    [SerializeField]
    private Collector collectorCoins;

    public void AddCoin()
    {
        CountCoins++;
    }

    public void Damage(int damage)
    {
        Health -= damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Bomb bomb))
        {
            Damage(50);
            bomb.Damage();
        }

        if (other.TryGetComponent(out Coin coin))
        {
            coin.Collect();
            AddCoin();


            if (collectorCoins != null)
            {
                collectorCoins.WriteCoins(CountCoins);
            }
        }

        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
