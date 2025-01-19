using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rabbit : MonoBehaviour
{
   public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
    public float speed = 3.0f;

    public float rabbitTime = 12.0f;

     public GameObject victoryPrefab;

     AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    

        move = MoveAction.ReadValue<Vector2>();

        rabbitTime -= Time.deltaTime;

        if (rabbitTime <= 0.0f)
{
   rabbitEnded();
}

    }

        void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

     public void trueVictory()
    {
       rabbitVictory();
    }

    public void CarrotEat()
    {
        GetComponent<AudioSource>().Play();
     speed = 9.0f;
    }

    void rabbitEnded()
{
   Destroy(gameObject);
}

void rabbitVictory()
{
  Instantiate(victoryPrefab, transform.position, transform.rotation);
}
}
