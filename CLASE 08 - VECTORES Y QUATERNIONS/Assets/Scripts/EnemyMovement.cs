using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] Vector3 direction = new Vector3(0, 0, 1);
    [SerializeField] float speed = 2f;

    [SerializeField] float offsetX = 20f;

    [SerializeField] bool isLeft = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(isLeft){
            MoveEnemy(Vector3.left);
        }else
        {
            MoveEnemy(Vector3.right);
        }

  
        if (transform.position.x < -offsetX)
        {
            isLeft = false;
        }

        if (transform.position.x > offsetX)
        {
            isLeft = true;
        }
    }

    private void MoveEnemy(Vector3 directionEnemy)
    {
        transform.Translate(speed * Time.deltaTime *  directionEnemy);
    }
}
