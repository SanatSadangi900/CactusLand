using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float speed = 20f;
    private float turnSpeed = 50f;
    private float horizontalInput;
    private float forwardInput;
    public float gravityModifier = 10;
    //public GameObject[] selectorArr;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        //Vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Horzontial Input
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown("p"))
        {
            mainMenu();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Cactus"))
        {
            reloadLevel();
        }

        if (collision.gameObject.CompareTag("Bone"))
        {
            nextLevel();
        }

        if (collision.gameObject.CompareTag("BoneInfinite"))
        {
            mainMenu();
        }
    }

    public void reloadLevel()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextLevel()
    { //Aespa is here. Flash just leveled up.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0);
    }


}
