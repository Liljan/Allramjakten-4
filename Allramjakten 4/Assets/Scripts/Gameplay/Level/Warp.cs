using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public Warp target;
    private BoxCollider2D bc2D;

    private void Awake()
    {
        bc2D = gameObject.GetComponent<BoxCollider2D>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = target.transform.position;
        StartCoroutine(DisablePortal(0.2f));
    }

    private IEnumerator DisablePortal(float waitTime)
    {
        target.SetEnabled(false);
        yield return new WaitForSeconds(waitTime);
        target.SetEnabled(true);
    }

    public void SetEnabled(bool b)
    {
        bc2D.enabled = b;
    }
}
