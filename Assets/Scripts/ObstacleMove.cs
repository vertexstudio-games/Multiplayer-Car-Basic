using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private float speedX = 5f;
    [SerializeField] private float speedY = 10f;
    private float speedCurrent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speedCurrent = Random.Range(speedX, speedY);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward * speedCurrent * Time.deltaTime);
    }
}
