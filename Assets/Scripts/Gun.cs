using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private AudioSource bulletSound;

    [SerializeField]
    private float bulletVelocity;

    private float timer = 0f;

    [SerializeField]
    private float timeQueue = 0.5f;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (bullet != null)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (timer > timeQueue)
                {
                    timer = 0;
                    CreateBullet();

                    if (bulletSound != null)
                    {
                        bulletSound.Play();
                    }
                }
            }
        }
    }

    private void CreateBullet()
    {
        var bulletPrefab = Instantiate(bullet, transform.position, transform.rotation);
        if (bulletPrefab.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(transform.forward * bulletVelocity, ForceMode.VelocityChange);
        }
    }
}
