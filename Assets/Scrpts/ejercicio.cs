using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Realizar el programa que permita ingresar por inspector el código de la categoría del animal y cuántos días va a quedarse. 

El programa debe cumplir los siguientes requerimientos:

Debe devolver el mensaje “Para ese período se necesitan  ” + [peso en gramos del alimento] + “ gramos de alimento”.

Sabiendo que el precio del alimento es de $80 por 100g, agregar un mensaje que muestre el costo de la cantidad de alimento calculada.

Debe mostrar mensajes de error(y no realizar el cálculo) si se ingresa un código no válido o si se ingresa una cantidad de días menor a 3.
*/
public class ejercicio : MonoBehaviour
{
    public int dias;
    public string codigo;
    // Start is called before the first frame update
    void Start()
    {  if (dias < 3)
        {
            Debug.Log("La cantidad minima de dias es igual o mayor 3, por favor ingrese otro numero de dias");
        }
        else if (codigo == "G")
        {
            int resultadoG;
            int resultadopesosG;
            resultadoG = dias * 300;
            Debug.Log("Para este periodose nesecitan " + resultadoG + "gramos de alimento");
            resultadopesosG = resultadoG / 100 * 80;
            Debug.Log("El costo de la cantidad de gramos es " + resultadopesosG);
       }
       else if (codigo == "PG")
        {
            int resultadoPG;
            int resultadopesosPG;
            resultadoPG = dias * 700;
            Debug.Log("Para este periodose nesecitan " + resultadoPG + "gramos de alimento");
            resultadopesosPG = resultadoPG / 100 * 80;
            Debug.Log("El costo de la cantidad de gramos es " + resultadopesosPG);
        }
       else if ( codigo == "PP")
        {
            int resultadoPP;
            int resultadopesosPP;
            resultadoPP = dias * 400;
            Debug.Log("Para este periodose nesecitan " + resultadoPP + "gramos de alimento");
            resultadopesosPP = resultadoPP / 100 * 80;
            Debug.Log("El costo de la cantidad de gramos es " + resultadopesosPP);
        }
        else
        {
            Debug.Log("Su codigo es invalido, por favor ingrese otro codigo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
