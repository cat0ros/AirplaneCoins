using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private GameObject effectBoom;

    public void Damage()
    {
        var effect = Instantiate(effectBoom, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
