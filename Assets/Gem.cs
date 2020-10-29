﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player" || other.gameObject.name == "Shadow")
        {
            Destroy(gameObject);
            GameState.Instance.GemCollected();
        }   
    }
}
