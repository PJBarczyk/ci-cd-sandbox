using UnityEngine;

public class Spin : MonoBehaviour
{
    public float RPM;
    
    void Update()
    {
        transform.Rotate(0, RPM * Time.deltaTime, 0);
    }
}