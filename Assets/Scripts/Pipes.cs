using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 1f;

    //UPDATE a cada vez que é chamado tem uma diferença, ele sempre otimiza para velocidade ficar igual de maquina para maquina 
    private void Update() 
    {
        transform.position += speed
            * Time.deltaTime * Vector3.left;
 }
}