using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fibonacci : MonoBehaviour
{
      public Button Fib_button;
    float max_number = 0;

    public TextMeshProUGUI display_value_placeholder;

  public void NextNumber()
 {
     display_value_placeholder.text = "";
     max_number ++;

     GetFibonacci(max_number, display_value_placeholder);
 }
 private void GetFibonacci(float num, TextMeshProUGUI display_value)
 {
     
     long fib1 = 0;
     long fib2 = 1;
     long next_fib = 0;

        
     for (int i = 1; i <= num; i++)
     {
         if (i == 1)
         {
             display_value.text += fib1 + ", ";
         }
         else if(i == 2)
         {
             display_value.text += fib2 + ", ";
         }
         else
         {
             next_fib = fib1 + fib2;
             fib1 = fib2;
             fib2 = next_fib;

        
             display_value.text += next_fib + ", ";
         }
     }

 }
}
