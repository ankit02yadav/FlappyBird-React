using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public Rigidbody2D Myrigidbody;
    public float upthrust;
    public logicScript logic;
    public bool BirdAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && BirdAlive == true)
        {
            Myrigidbody.linearVelocityY = upthrust;
        }
        if(transform.position.y>5 || transform.position.y < -5)
        {
            BirdAlive = false;
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BirdAlive = false;
        logic.gameOver();
    }
}
