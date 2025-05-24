using MyBox;
using Unity.Mathematics;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    [SerializeField] private float myFloat;

[ButtonMethod] //ist wie context menu nur mit button im inspktor
    void Start()
    {
        if ((myFloat > 5f && myFloat < 10f) ||Mathf.RoundToInt(myFloat) == 21f)
        {
            Debug.Log("ist groeser als 5");
            //schau nach ob die zahl groeßer als 5 ist UND kleiner als 10 ODER wenn es eine Aufgerundet 21 ist 
        }
    }
}