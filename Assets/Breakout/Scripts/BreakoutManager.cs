using System.Collections;   
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakoutManager : MonoBehaviour
{
    //I use a static variable to make this accessible from anywhere
    //You can access this variable from anywhere by typing 'BreakoutManager.Me'
    //No need to capture the BreakoutManager in a variable name first, like you usually need
    public static BreakoutManager Me;
    //As a manager, I keep a link to all the major game elements
    public PaddleController Paddle;
    public BallController Ball;
    
    //The brick prefab
    public BrickController BrickPrefab;
    
    //I keep a list of all bricks that exist
    public List<BrickController> AllBricks;
    
    void Start()
    {
        //I need to register myself as 'the' BreakoutManager
        BreakoutManager.Me = this;

        //This is the code for spawning bricks. It's not very good.
        //How could we make this spawn lots of bricks more efficiently?
        Instantiate(BrickPrefab, new Vector3( Random.Range(-8f,8f), 0), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1.5f, 0), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(2, 1.1f, 0f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1.3f, 1.3f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(2, 1.7f, 1.1f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1.2f, 1.0f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1.34f, 0.7f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1.6f, 3f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(2, 1.1f, 2f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1f, 2f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 0.9f, 0.5f), Quaternion.identity);
        //Instantiate(BrickPrefab, new Vector3(1, 1.07f,1f), Quaternion.identity);
        //Instantiate(BrickPrefab, new Vector3(2, 1.1.7f, 1f), Quaternion.identity); 
        Instantiate(BrickPrefab, new Vector3(1, 1.21f, 1f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(2, 1.01f, 1f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1.04f, 1f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(3, 1.22f, 1f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1.03f, 1f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(3, 1.41f, 0.7f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 1.7f, 2f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(2, 1.7f, 0f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 0.1f, 1f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(1, 0.7f, 8f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(2, 0.8f, 5f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(0, 0.5f, 7f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(3, 0.2f, 2f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(0, 0.4f, 1f), Quaternion.identity);
        Instantiate(BrickPrefab, new Vector3(0, 1.3f, 1.2f), Quaternion.identity);
    }

void Update()
    {
        //Check to see if all the bricks have been broken
        if (AllBricks.Count == 0)
        {
            //If so, win
            SceneManager.LoadScene("You Win");
        }
    }
    

    
}
    