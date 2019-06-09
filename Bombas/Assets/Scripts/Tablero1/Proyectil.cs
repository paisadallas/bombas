using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//*** NOTA: NO PUEDO DESTRUIR LOS OBJETOS DEBIDO A QUE ESTOY USANDO LAS FUNCIONES DE OTRAS CLASES
// AL CREAR EL PREFAB NO ME PERMITE USAR LOS COMPONENTES PUBLICOS YA QUE LOS SCRIPT NO SE INICIALIZAN EN LE PREFABS


public class Proyectil : MonoBehaviour
{
   
    private Rigidbody2D rb2d;
    private Rigidbody2D slingRb;
    private SpringJoint2D sj2d;
    private bool press;
    private float relaseDealy;
    private float disMax = 2f;      
    private Transform coordenadaPiedra;
    public bool cargado;
    private float posX;
    private void Start()
    {
        sj2d.enabled = true;
        coordenadaPiedra = GetComponent<Transform>();
        cargado = true;
    }

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sj2d = GetComponent<SpringJoint2D>();
        slingRb = sj2d.connectedBody;
        relaseDealy = 1 / (sj2d.frequency * 4);   // separar objeto en un tiempo x 
       

    }
    void Update()
    {
        if (press)
        {
            arrastrarBola();
        }                
    }
    
    private void arrastrarBola()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(mousePosition, slingRb.position);
        rb2d.position = mousePosition;
        posX = mousePosition.x;
        if (distance > disMax)
        {
            Vector2 direction = (mousePosition - slingRb.position).normalized;
            rb2d.position = slingRb.position + direction * disMax;
            
        }
        else
        {

        }
    }
    //proyectil en disparador  objeto en catapulta
    private void OnMouseDown()
    {
        press = true;
        rb2d.isKinematic = true;
        cargado = true;

    }
    // proyectil lanzado objeto lanzado
    private void OnMouseUp()
    {
        press = false;
        rb2d.isKinematic = false;
        StartCoroutine(Release());
        cargado = false;     
     //  nuevoProyectil.crearProyectil(true,coordenadaPiedra.position.x);   //nuevo proyectil y nueva posicion
        
    }
    // permite arrastrar mi proyectil
    private IEnumerator Release()
    {
        yield return new WaitForSeconds(relaseDealy);
        sj2d.enabled = false;
              
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        //Generamos Nuevo proyectil
        if (otro.gameObject.tag == "Proyectiles")
        {
        
            Instantiate(this.gameObject, new Vector3(posX, -7, 73), Quaternion.identity);
        }


        if (otro.gameObject.tag == "suelo")
        {
           // Debug.Log("Destruido");
            Destroy(this.gameObject);
        }


    }
}
