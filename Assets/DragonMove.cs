using UnityEngine;

public class DragonMove : MonoBehaviour
{
    public float raio = 30.0f; 
    public float velocidadeRotacao = 30.0f;

    private Vector3 centroDoCirculo;
    private float angulo = 0.0f;

    private void Start()
    {
        centroDoCirculo = transform.position;
    }

    private void Update()
    {
        float x = centroDoCirculo.x + raio * Mathf.Cos(angulo * Mathf.Deg2Rad);
        float z = centroDoCirculo.z + raio * Mathf.Sin(angulo * Mathf.Deg2Rad);

        transform.position = new Vector3(x, transform.position.y, z);
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, -0.03f, 0);

        angulo += velocidadeRotacao * Time.deltaTime;

        if (angulo >= 360.0f)
        {
            angulo -= 360.0f;
        }
    }
}