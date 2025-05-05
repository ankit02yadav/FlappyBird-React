using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{
    public logicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //logic = GameObject.FindGameObjectWithTag("Logic");
        //logic = GameObject.FindGameObjectsWithTag("Logic").GetComponent<logicScript>(); // multiple objects
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
