using UnityEngine;

public class pipemove : MonoBehaviour
{
    public float movespeed = 5;
    public float DeadZone = -15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}
