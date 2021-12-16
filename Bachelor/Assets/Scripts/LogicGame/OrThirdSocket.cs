using UnityEngine;
using UnityEngine.UI;

public class OrThirdSocket : MonoBehaviour
{
  private Vector3 _orGate = new Vector3(7.89499998f, 1.28100002f, 0.786000013f);

  private void Update()
  {
    if (transform.position == _orGate)
    {
      CheckPositionOrTwo();
    }
  }

  private void CheckPositionOrTwo()
  {
    if (GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material
      .IsKeywordEnabled("_EMISSION") || GameObject.FindGameObjectsWithTag("AndTwoTag")[2].GetComponent<Renderer>()
      .material.IsKeywordEnabled("_EMISSION"))
    {
      GameObject.FindGameObjectsWithTag("OrOneTag")[0].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("OrOneTag")[1].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("OrOneTag")[2].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
    else
    {
      GameObject.FindGameObjectsWithTag("OrOneTag")[0].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("OrOneTag")[1].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("OrOneTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
  }
}
