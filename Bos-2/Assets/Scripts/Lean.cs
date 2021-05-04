using UnityEngine;

public class Lean : MonoBehaviour
{

    private float _leanX;
    private float _weightMatrix;
    


    private void Update()
  {
      

      if (Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.X))
      {
          _leanX += 1f;  
      } else if (Input.GetKey(KeyCode.M) && Input.GetKey(KeyCode.X))
      {
          _leanX -= 1f;
      }

      _weightMatrix = 0f; // temp
       
      Mathf.Clamp(_leanX, -90, 90);
      Mathf.Clamp(_weightMatrix, -1f, 1f);
      this.transform.localRotation = Quaternion.Euler(0f, _leanX, 0f);

  }
}
