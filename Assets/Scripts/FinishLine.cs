using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem finished;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Head" || other.tag == "Respawn")
        {
            finished.Play();
            Debug.Log("I am here?");
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", delay);
        }

    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
