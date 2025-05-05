using UnityEngine;

public class pipespanner : MonoBehaviour
{
    public GameObject pipe;
    public float SpaneRate = 2;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpwanPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < SpaneRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            timer = 0;
            SpwanPipes();
        }
    }
    void SpwanPipes()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float heighestpoint = transform.position.y + heightoffset; 
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,heighestpoint),0), transform.rotation);
    }
}
