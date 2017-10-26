using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    private AudioSource audioSource;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        audioSource.Play();
        Invoke("DestroyObject", 0.2f);
    }

    private void DestroyObject() {
        Destroy(gameObject);
    }
}
