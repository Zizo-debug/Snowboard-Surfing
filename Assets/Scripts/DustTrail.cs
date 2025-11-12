using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem detect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Ground")
            {
                detect.Play();
            }

        }
        void OnCollisionExit2D(Collider2D other)
        {
            if (other.gameObject.tag == "Ground")
            {
                detect.Stop();
            }

        }
    }
}