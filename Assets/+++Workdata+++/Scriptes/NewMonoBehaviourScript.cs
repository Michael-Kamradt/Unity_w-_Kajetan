using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //die wichtigsten variablen
    private bool _fistBool;
    private int _fistInt;
    private string _fistString;
    
    //für den fame zaeler
    private int _i;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _fistBool = true;
        _fistInt = 8;
        _fistString = "Hello";
        Debug.Log("Start " + _fistBool + " " + _fistInt + " " + _fistString);
        Debug.Log(_fistBool);
        Debug.Log(_fistInt);
        Debug.Log(_fistString);
        
        //int +5
        
        Debug.Log(_fistInt + " + 5"); //ausgabe der aufgabe
        _fistInt = _fistInt + 5 ; //aufgabe wird intern gerechnet
        
        Debug.Log(_fistInt); //ausgabe das ergebniss

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("Frame "+ _i++);
        //zaelt für mich die frames. allles was nach + kommt wird zum string

    }
}
