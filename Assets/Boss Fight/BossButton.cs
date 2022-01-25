using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossButton : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject catusKing;

    public GameObject catusKing3;

    public GameObject part2;

    public GameObject button;
    public int xPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Player"))
        {
            //xPos = Random.Range(25, 74);
            Destroy(button);
            Destroy(catusKing);
            Instantiate(catusKing3, new Vector3(54.97f, 13.9f, 97.43f), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            Instantiate(part2, new Vector3(0, 19.24f, 68), Quaternion.Euler(new Vector3(0, 0, 0))/*Quaternion.identity*/);
            nextLevel();
        }
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0);
    }

    public void nextLevel()
    { //Aespa is here. Flash just leveled up.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
