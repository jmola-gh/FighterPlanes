using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyElite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(3, 0, 0) * Time.deltaTime * 3f);

        if (transform.position.x > 12f)
        {
            Destroy(this.gameObject);
        }
    }
}
