using UnityEngine;
using UnityEngine.UI;

public class AndOneFirstSocket : MonoBehaviour
{
  private Vector3 _andGate = new Vector3(7.91100025f, 1.00600004f, 0.521999955f);

  private void Update()
  {
    if (transform.position == _andGate)
    {
      CheckPositionOne();
    }
  }

  private void CheckPositionOne()
  {
    if (GameObject.FindGameObjectWithTag("LedLamp1").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION") &&
        GameObject.FindGameObjectWithTag("LedLamp2").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
    {
      GameObject.FindGameObjectsWithTag("AndOneTag")[0].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("AndOneTag")[1].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
    else if (GameObject.FindGameObjectWithTag("LedLamp1").GetComponent<Renderer>().material
      .IsKeywordEnabled("_EMISSION"))
    {
      GameObject.FindGameObjectsWithTag("AndOneTag")[0].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("AndOneTag")[1].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
    else if (GameObject.FindGameObjectWithTag("LedLamp2").GetComponent<Renderer>().material
      .IsKeywordEnabled("_EMISSION"))
    {
      GameObject.FindGameObjectsWithTag("AndOneTag")[0].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("AndOneTag")[1].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
    else
    {
      GameObject.FindGameObjectsWithTag("AndOneTag")[0].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("AndOneTag")[1].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
      GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
  }
}
