using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void numberLevels()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0 + 3);
    }

    public void infiniteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0 + 1);
    }

    public void dodgeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0 + 2);
    }
}
