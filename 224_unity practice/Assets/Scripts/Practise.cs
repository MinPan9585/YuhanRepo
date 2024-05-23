using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Practise : MonoBehaviour
{
    public bool bb;
    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log("Hello World!");
         int a, b, c;
         a = 3;
         b = 4;
         c = 5;
         //条件语句
         if (bb)
         {
             Debug.Log("A");

         }
         else
         {
             Debug.Log("B");
         }

         //while循环语句
         int sum = 0;
         int i = 1;
         while (i <= 100)
         {
             sum += i;
             i += 1;
         }
         //Debug.Log(sum);

         //for循环
         for (int j = 1; j <= 100; j += 1)
         {
             sum += j;
         }
         float x = 5;
         float y = 6;
         float z = Mult(x, y);
         Debug.Log(z);
         y = Mult(z, x);*/
        bool a = IsPrime(5);
        Debug.Log(a);

        PrintRank(3);
     }

     float Mult(float f1, float f2)
     {
         return f1 * f2;
     }
    bool Func(int f)
    {
        int i = 1;
        while (i <= f)
        {
            if (i % 7 == 0)
            {
                return true;
            }
            else i += 1;
        }
        return false; 
    }
    bool IsPrime(int z)
    {
        for (int i = 2; i < z;i++)
        {
            if (z % i == 0)
            {
                return false;
            }
        }
        return true;
    }



    



        void PrintRank(int n)
        {

                if (n>=85)
                {
                    Debug.Log("A");
                }
                if (n>=70)
                {
                    Debug.Log("B");
                }
                if (n>=60)
                {
                    Debug.Log("C");
                }
                else
                {
                    Debug.Log("D");
                }
            
        }
    
    
   



    // Update is called once per frame
    void Update()
    {
        
    }
}

