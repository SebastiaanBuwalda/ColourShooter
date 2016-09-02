using UnityEngine;using System.Collections;public class MoveWithRandomVector : MonoBehaviour {    [SerializeField]    private bool changeAtIntervalls = false;    [SerializeField]    private float timeInterval = 1F;    [SerializeField]    private float minimumYVector = -2;    [SerializeField]    private float maximumYVector = 2;    [SerializeField]    private float minimumXVector = -2;    [SerializeField]    private float maximumXVector = 2;    private Vector2 moveVector;    void OnEnable()    {
        regenerateVector();    }    void Update ()    {        transform.Translate(moveVector * Time.deltaTime, Space.World);    }    void regenerateVector()
    {
        moveVector = new Vector2(Random.Range(minimumXVector, maximumXVector), Random.Range(minimumYVector, maximumYVector));
        if(changeAtIntervalls)
        {
            StartCoroutine(waitTime());
        }
    }    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(timeInterval);
        regenerateVector();
    }}