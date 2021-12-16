using UnityEngine;
using UnityEngine.UI;

public class OrSecondSocket : MonoBehaviour
{
  private Vector3 _orGate = new Vector3(7.91100025f, 1.47800004f, 0.52700001f);

  private void Update()
  {
    if (transform.position == _orGate)
    {
      CheckPositionOrTwo();
    }
  }

  private void CheckPositionOrTwo()
  {
    if (GameObject.FindGameObjectWithTag("LedLamp3").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION") ||
        GameObject.FindGameObjectWithTag("LedLamp4").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
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
