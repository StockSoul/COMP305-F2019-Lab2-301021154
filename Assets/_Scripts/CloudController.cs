using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

/* Andrew Trinidad
 * 3010201154
 * Program Modifications: 
 * -Added colour pulsing
 */
public class CloudController : MonoBehaviour
{
    [Header("Speed Values")]
    [SerializeField]
    public Speed horizontalSpeedRange;

    [SerializeField]
    public Speed verticalSpeedRange;

    public float verticalSpeed;
    public float horizontalSpeed;

    [SerializeField]
    public Boundary boundary;

    private SpriteRenderer spriteRenderer;

    private Color halfRed;
    private Color halfWhite;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        halfRed = new Color(1.0f, 0.0f, 0.0f, 0.5f);
        halfWhite = new Color(1.0f, 1.0f, 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //pulse the colour of the clouds from red to white
        spriteRenderer.material.color = 
            Color.Lerp(halfRed, halfWhite, Mathf.PingPong(Time.time, 1));
        Move();
        CheckBounds();
    }

    /// <summary>
    /// This method moves the ocean down the screen by verticalSpeed
    /// </summary>
    void Move()
    {
        Vector2 newPosition = new Vector2(horizontalSpeed, verticalSpeed);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

    /// <summary>
    /// This method resets the ocean to the resetPosition
    /// </summary>
    void Reset()
    {
        horizontalSpeed = Random.Range(horizontalSpeedRange.min, horizontalSpeedRange.max);
        verticalSpeed = Random.Range(verticalSpeedRange.min, verticalSpeedRange.max);

        float randomXPosition = Random.Range(boundary.Left, boundary.Right);
        transform.position = new Vector2(randomXPosition, Random.Range(boundary.Top, boundary.Top + 2.0f));
    }

    /// <summary>
    /// This method checks if the ocean reaches the lower boundary
    /// and then it Resets it
    /// </summary>
    void CheckBounds()
    {
        if (transform.position.y <= boundary.Bottom)
        {
            Reset();
        }
    }
}
