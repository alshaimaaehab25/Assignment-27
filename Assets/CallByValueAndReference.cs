using UnityEngine;

namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        void Start()
        {
            int a = 5;
            int b = 10;
            CallByValue(a);
            Debug.Log("Value of 'a' after CallByValue: " + a); 

            CallByReference(ref b);
            Debug.Log("Value of 'b' after CallByReference: " + b); 

          
            int c; 
            CallByOut(out c);
            Debug.Log("Value of 'c' after CallByOut: " + c); 
        }

        
        void CallByValue(int x)
        {
            x += 10;
            Debug.Log("Value inside CallByValue method: " + x); 
        }

        
        void CallByReference(ref int y)
        {
            y += 10;
            Debug.Log("Value inside CallByReference method: " + y);
        }

       
        void CallByOut(out int z)
        {
            z = 30; 
            Debug.Log("Value inside CallByOut method: " + z); 
        }
    }
}
