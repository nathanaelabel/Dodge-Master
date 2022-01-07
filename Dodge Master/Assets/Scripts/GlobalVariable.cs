using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariable : MonoBehaviour
{
    // Start is called before the first frame update
    private static int SkorEasy;
    private static int SkorHard;

    public int getSkorEasy()
    {
        return SkorEasy;
    }

    public int getSkorHard()
    {
        return SkorHard;
    }

    public void setSkorEasy(int newSkorEasy)
    {
        if (SkorEasy < newSkorEasy)
        {
            SkorEasy = newSkorEasy;
        }

    }

    public void setSkorHard(int newSkorHard)
    {
        if (SkorHard < newSkorHard)
        {
            SkorHard = newSkorHard;
        }

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
