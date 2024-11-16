using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
   static public int x;
    public int y;
    public Text score;
    public Text goal;
    public Text test;
    // Start is called before the first frame update
    void Start()
    {
        test.text = "ћ€ч не в руках";
        x = 0;
        y = 5;
        goal.text = " онечна€ цель:" + y.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score.text = x.ToString();
        if (x >= y)
        {
            goal.text = "÷ель достигнута";
        }
    }
    public void testball()
    {
        test.text = "ћ€ч в руках";
    }
    public void testunball()
    {
        test.text = "ћ€ч не в руках";
    }
}
