using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private bool _isInRange;
    public MoveElevator _moveElevator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boulder"))
        {
            _isInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boulder"))
        {
            _isInRange = false;
        }
    }

    private void Update()
    {
        if ( _isInRange)
        {
            _moveElevator.Do();
        }
    }
}
