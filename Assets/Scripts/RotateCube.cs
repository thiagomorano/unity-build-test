using UnityEngine;

public class RotateCube : MonoBehaviour
{
  // Start is called once before the <first execution of Update after the MonoBehaviour is created
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    this.transform.Rotate(new Vector3(0, 1, 0));
  }
}
