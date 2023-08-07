using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.position +=transform.forward *speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
    private void Start()
    {
        Destroy(gameObject, 3);
    }
}
