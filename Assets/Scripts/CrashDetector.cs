using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float Delay = 0.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        if (collision.tag == "Ground")
        {
            Invoke("ReloadScene", Delay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
