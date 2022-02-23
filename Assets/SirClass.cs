using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirClass : MonoBehaviour
{
    public MyStudent[] myStudents;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in myStudents)
        {
            Debug.Log(item.studentid);
            Debug.Log(item.studentname);
            Debug.Log(item.studentdiscription);


        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
[System.Serializable]
public class MyStudent
{
    public int studentid;
    public int studentname;
    public int studentdiscription;

}