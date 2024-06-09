using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    private float time = 0;    

    void Update()
    {
        time += Time.deltaTime;

        if (time > 5f)
        {
            Destroy(gameObject);
        }
    }
}
