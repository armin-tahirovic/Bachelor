using UnityEngine;
using UnityEngine.UI;

public class OrFirstSocket : MonoBehaviour
{
  private Vector3 _orGate = new Vector3(7.91100025f, 1.00600004f, 0.521999955f);

  private void Update()
  {
    if (transform.position == _orGate)
    {
      CheckPosition();
    }
  }

  private void CheckPosition()
  {
    if (GameObject.FindGameObjectWithTag("LedLamp1").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION") ||
        GameObject.FindGameObjectWithTag("LedLamp2").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
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
