using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(Vector3.forward(),(getInput("Mouse Y")-0)/(getInput("Mouse X")-0))
    }

    // Update is called once per frame
    void Update()
    {

    }
}
