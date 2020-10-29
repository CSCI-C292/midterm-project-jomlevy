using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform movePoint;
    public LayerMask whatStopsMovement;
    public bool movePossible = false;
    [SerializeField] Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!movePossible && !GameState.Instance.isGameOver)
        {
            Movement();
            ResetPlayers();
        } 
    }

    void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, 1);
        Vector3 pos = movePoint.position;
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(-1, 0, 0), .2f, whatStopsMovement))
            {
                pos.x -= 1;
            }
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(1, 0, 0), .2f, whatStopsMovement))
            {
                pos.x += 1;
            }
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(0, -1, 0), .2f, whatStopsMovement))
            {
                pos.y -= 1;
            }
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(0, 1, 0), .2f, whatStopsMovement))
            {
                pos.y += 1;
            }
        }
        movePoint.position = pos;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name == "PlayerGoal" || other.gameObject.name == "ShadowGoal")
        {
            movePossible = true;
        }
    }

    void ResetPlayers()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.position = initialPosition;
            movePoint.position = initialPosition;
        }
    }
    
}
