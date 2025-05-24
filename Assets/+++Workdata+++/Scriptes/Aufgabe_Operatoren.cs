using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Aufgabe_Operatoren : MonoBehaviour
{
   
    public float _fistInt;
    public float _secondInt;
    private float _ergebnis;
    // public enum _operator um eine liste mit operatoren auszugeben
    public string _operator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _taschenrechner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void _taschenrechner()
    {
      
        //man könnte auch mit einem Switch statment machen
        if (_operator == "+")
        {
            Debug.Log(_fistInt + " + " + _secondInt);
            _ergebnis = _fistInt + _secondInt;
            Debug.Log("ergebnis " + _ergebnis); 
        }
        else if (_operator == "-")
        {
            Debug.Log(_fistInt + " - " + _secondInt);
            _ergebnis = _fistInt - _secondInt;
            Debug.Log("ergebnis " + _ergebnis);
        }    
        else if (_operator == "*")
        {
            Debug.Log(_fistInt + " * " + _secondInt);
            _ergebnis = _fistInt * _secondInt;
            Debug.Log("ergebnis " + _ergebnis);
        } 
        else if (_operator == "/")
        {
            Debug.Log(_fistInt + " / " + _secondInt);
            _ergebnis = _fistInt / _secondInt;
            Debug.Log("ergebnis " + _ergebnis);
        }
        else if (_operator == "^")
        {
            
            Debug.Log(_fistInt + " ^ " + _secondInt);
            _ergebnis = Mathf.Pow(_fistInt, _secondInt);
            Debug.Log("ergebnis " + _ergebnis);
        }
        else if (_operator == "%")
        {
            Debug.Log(_fistInt + " % " + _secondInt);
            _ergebnis = _fistInt % _secondInt;
            Debug.Log("ergebnis " + _ergebnis);
        }
        else
        {
            //wenn was schief läuft
            Debug.Log("geht nicht");
            
        }  
    }
}

