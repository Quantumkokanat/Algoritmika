using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 10;
    public AudioSource damageAudio;
    public AudioClip collectSound;
    private int coins;
    public AudioSource collectSoundAudioSource;
    public AudioClip damageSound;
    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void CollectCoins()
    {
        coins++;

        //collectSoundAudioSource.PlayOneShot(collectSound);

        print("Собранные монетки: " + coins);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print(health);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }


}
