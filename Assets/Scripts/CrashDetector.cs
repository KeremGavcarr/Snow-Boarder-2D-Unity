using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float Delay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        if (collision.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", Delay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
