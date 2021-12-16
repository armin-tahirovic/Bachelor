using UnityEngine;
using UnityEngine.UI;

public class AndTwoSecondSocket : MonoBehaviour
{
    private Vector3 _andGate = new Vector3(7.91100025f, 1.47800004f, 0.52700001f);

    public Text output;

    private void Update()
    {
        if (transform.position == _andGate)
        {
            CheckPosition();
        }

    }

    private void CheckPosition()
    {

        if ( GameObject.FindGameObjectWithTag("LedLamp3").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION") && GameObject.FindGameObjectWithTag("LedLamp4").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
        {
            output.text = GameObject.FindGameObjectsWithTag("AndTwoTag").Length.ToString();

            GameObject.FindGameObjectsWithTag("AndTwoTag")[0].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[1].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[2].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
        else if( GameObject.FindGameObjectWithTag("LedLamp3").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
        {
            GameObject.FindGameObjectsWithTag("AndTwoTag")[0].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[1].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
        else if(GameObject.FindGameObjectWithTag("LedLamp4").GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
        {
            GameObject.FindGameObjectsWithTag("AndTwoTag")[0].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[1].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

        }
        else
        {
            GameObject.FindGameObjectsWithTag("AndTwoTag")[0].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[1].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }


}
