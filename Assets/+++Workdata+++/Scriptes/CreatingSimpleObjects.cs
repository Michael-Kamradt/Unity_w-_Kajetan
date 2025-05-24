using MyBox;
using UnityEngine;

public class CreatingSimpleObjects : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [ButtonMethod]
    void Start()
    {
        GameObject goMySphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        
        goMySphere.transform.position = new Vector3(2, 3, 0);
        
        goMySphere.transform.position = goMySphere.transform.position + new Vector3(-2,-3, 0);
    }

}
