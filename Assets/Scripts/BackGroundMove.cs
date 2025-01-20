using UnityEditor;
using UnityEngine;

public class BackGroundMove
{
    public float moveSpeed ;
    public float moveRange ;
    private Vector3 oldPosition;
    private GameObject obj;

    void Start()
    {
        obj = gameObject;
    }
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed,  .y, 0));
    }
}
