using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lean : MonoBehaviour
{

    public float _leanX;
    public float _leanY;
    
    
    
  private void Update()
  {
      

      if (Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.X))
      {
          _leanX += 1f;  
      } else if (Input.GetKey(KeyCode.M) && Input.GetKey(KeyCode.X))
      {
          _leanX -= 1f;
      } else if (Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.Y))
      {
          _leanY += 1f;  
      } else if (Input.GetKey(KeyCode.M) && Input.GetKey(KeyCode.Y))
      {
          _leanY -= 1f;
      }
       
      Mathf.Clamp(_leanX, -90, 90);
      Mathf.Clamp(_leanY, -90, 90);
      this.transform.localRotation = Quaternion.Euler(0f, _leanX, _leanY);
     
  }
}
