using UnityEngine;


public class AndTwoThirdSocket : MonoBehaviour
{
    private Vector3 _andGate = new Vector3(7.89499998f, 1.28100002f, 0.786000013f);



    private void Update()
    {
        if (transform.position == _andGate)
        {
            CheckPositionOne();
        }


    }

    private void CheckPositionOne()
    {

        if (GameObject.FindGameObjectsWithTag("AndTwoTag")[2].GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION") && GameObject.FindGameObjectsWithTag("OrOneTag")[2].GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
        {

            GameObject.FindGameObjectsWithTag("AndOneTag")[0].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndOneTag")[1].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
        else if(GameObject.FindGameObjectsWithTag("AndTwoTage")[2].GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
        {
            GameObject.FindGameObjectsWithTag("AndOneTag")[0].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndOneTag")[1].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
        else if( GameObject.FindGameObjectsWithTag("OrOneTag")[2].GetComponent<Renderer>().material.IsKeywordEnabled("_EMISSION"))
        {
            GameObject.FindGameObjectsWithTag("AndOneTag")[0].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndOneTag")[1].GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndOneTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

        }
        else
        {
            GameObject.FindGameObjectsWithTag("AndTwoTag")[0].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[1].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            GameObject.FindGameObjectsWithTag("AndTwoTag")[2].GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }


}
