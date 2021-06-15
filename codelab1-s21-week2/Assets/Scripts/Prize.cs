using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prize : MonoBehaviour

{
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnCollisionEnter2D(Collision2D other)
        
        {
            transform.position = new Vector2( //teleport to a random location
                Random.Range(-5, 5), //between -5 and 5 on the x
                Random.Range(-5, 5)); //between -5 and 5 on the y 

            GameManager.instance.score++; //increase the player's score using the Singleton!! so increases by + 1 
            
            print("Score: " + GameManager.instance.score); //shows up on the console 
        }
}
